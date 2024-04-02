using FinansistWF;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace FinansistWF
{
    public partial class Form3 : Form
    {
        private string PuthDirectory;
        private string PuthExtract;
        private string PuthKey;
        int rowCountExtract;
        int columnCountDirectory;
        public Form3(string PuthDirectory, string PuthExtract, string puthKey)
        {
            InitializeComponent();
            this.PuthDirectory = PuthDirectory;
            this.PuthExtract = PuthExtract;
            PuthKey = puthKey;  
        }

        private void ExitLabel_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();

        private async void Form3_Load(object sender, EventArgs e)
        {
            await Task.Run(() => HelperWinForms.ReadExcelData(PuthDirectory,dataGridView1));
        }
       
        private void button1_Click(object sender, EventArgs e) => ProcessExcelFile(PuthDirectory,PuthKey);

        public void ProcessExcelFile(string filePath,string PuthKey)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Workbook excelWorkbook = null;
            Workbook excelWorkbookPuthKey = null;

            try
            {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelWorkbook = excelApp.Workbooks.Open(filePath);
                excelWorkbookPuthKey = excelApp.Workbooks.Open(PuthKey);
                // Получаем первый лист с реестром операций
                Worksheet registryWorksheet = excelWorkbook.Sheets[1];

                // Получаем третий лист с информацией о статьях
                Worksheet articlesWorksheet = excelWorkbookPuthKey.Sheets[1];

                // Получаем используемые диапазоны на листах
                Range registryRange = registryWorksheet.UsedRange;
                Range articlesRange = articlesWorksheet.UsedRange;

                // на листе реестра
                int registryCounterpartyColumnIndex = FindColumnIndex(registryRange, DictionaryOfWords.columnNameCounterparty);
                int registryPorpuseColumnIndex = FindColumnIndex(registryRange, DictionaryOfWords.columnNamePorpuse);
                int registryArticleColumnIndex = FindColumnIndex(registryRange, DictionaryOfWords.columnNameArticle);
                if (registryCounterpartyColumnIndex == -1 || registryPorpuseColumnIndex == -1 || registryArticleColumnIndex == -1)
                {
                    Console.WriteLine($"Столбцы '{DictionaryOfWords.columnNameCounterparty}', '{DictionaryOfWords.columnNameArticle}' и {DictionaryOfWords.columnNamePorpuse} не найдены на листе '{registryWorksheet.Name}'.");
                    return;
                }
                // на листе ключей
                int articlesArticleNameColumnIndex = FindColumnIndex(articlesRange, DictionaryOfWords.columnNameArticleName);
                int articlesDescriptionColumnIndex = FindColumnIndex(articlesRange, DictionaryOfWords.columnNameKeyDescription);
                int articlesCounterpartyColumnIndex = FindColumnIndex(articlesRange, DictionaryOfWords.columnNameKeyCounterparty);
                int articlesNumberOfContractColumnIndex = FindColumnIndex(articlesRange, DictionaryOfWords.columnNameNumberOfContract);
                if (articlesArticleNameColumnIndex == -1 || articlesDescriptionColumnIndex == -1 || articlesCounterpartyColumnIndex == -1 || articlesNumberOfContractColumnIndex == -1)
                {
                    Console.WriteLine($"Столбцы '{DictionaryOfWords.columnNameArticleName}', '{DictionaryOfWords.columnNameKeyDescription}', {DictionaryOfWords.columnNameKeyCounterparty} и {DictionaryOfWords.columnNameNumberOfContract} не найдены на листе '{articlesWorksheet.Name}'.");
                    return;
                }



                // Проходим по каждой строке на первом листе
                for (int i = 2; i <= registryRange.Rows.Count; i++)
                {
                    bool isNotFound = true;
                    Range registryRow = (Range)registryRange.Rows[i];

                    string counterparty = registryRow.Cells[registryCounterpartyColumnIndex].Value2?.ToString();
                    string porpuse = registryRow.Cells[registryPorpuseColumnIndex].Value2?.ToString().ToLower();

                    // Проходим по строкам на третьем листе
                    for (int j = 2; j <= articlesRange.Rows.Count; j++)
                    {
                        Range articleRow = (Range)articlesRange.Rows[j];

                        string foundCounterparty = articleRow.Cells[articlesCounterpartyColumnIndex].Value2?.ToString();
                        string foundDescription = articleRow.Cells[articlesDescriptionColumnIndex].Value2?.ToString().ToLower();
                        string foundNumberOfContract = articleRow.Cells[articlesNumberOfContractColumnIndex].Value2?.ToString().ToLower();
                        bool isValid = true;

                        if (!String.IsNullOrWhiteSpace(foundCounterparty))
                        {
                            if (counterparty == foundCounterparty)
                            {
                                if (!String.IsNullOrWhiteSpace(foundDescription))
                                {
                                    isValid &= porpuse.Contains(foundDescription);
                                }
                                if (!String.IsNullOrWhiteSpace(foundNumberOfContract))
                                {
                                    isValid &= porpuse.Contains(foundNumberOfContract);
                                }
                            }
                            else
                            {
                                isValid = false;
                            }
                        }
                        else
                        {
                            isValid = !String.IsNullOrWhiteSpace(foundDescription) &&
                            !String.IsNullOrWhiteSpace(foundNumberOfContract) &&
                            porpuse.Contains(foundDescription) &&
                            porpuse.Contains(foundNumberOfContract);
                        }

                        if (isValid)
                        {
                            isNotFound = false;
                            registryRow.Cells[registryArticleColumnIndex].Value2 = articleRow.Cells[articlesArticleNameColumnIndex].Value2;
                            break;
                        }
                    }

                    if (isNotFound)
                    {
                        registryRow.Cells[registryArticleColumnIndex].Interior.Color = ColorTranslator.ToOle(Color.Red);
                    }
                }

                // Сохраняем изменения в файле Excel
                excelWorkbook.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обработки файла Excel: {ex.Message}");
            }
            finally
            {
                if (excelWorkbook != null)
                    excelWorkbook.Close();

                if (excelApp != null)
                {
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        // Метод для поиска индекса столбца по его названию
        private int FindColumnIndex(Range range, string columnName)
        {
            int columnIndex = -1;

            for (int i = 1; i <= range.Columns.Count; i++)
            {
                string header = range.Cells[1, i].Value2?.ToString();
                if (header == columnName)
                {
                    columnIndex = i;
                    break;
                }
            }

            return columnIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormExtract(PuthExtract, PuthDirectory,PuthKey).ShowDialog();
        }
    }

}
