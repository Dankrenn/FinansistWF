using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;

namespace FinansistWF
{
    public partial class FormExtract : Form
    {
        private string PuthExtract;
        private string PuthDirectory;
        private string PuthKey;



        public FormExtract(string PuthExtract, string PuthDirectory,string PuthKey)
        {
            InitializeComponent();
            this.PuthKey = PuthKey;
            this.PuthExtract = PuthExtract;
            this.PuthDirectory = PuthDirectory;
        }

        private async void Form2_LoadAsync(object sender, EventArgs e)
        {
            await Task.Run(() => HelperWinForms.ReadExcelData(PuthExtract,dataGridView1));
        }

        private void ExitLabel_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                int starRows = Convert.ToInt32(NumberStart.Text);
                int endRows = Convert.ToInt32(NumberEnd.Text);
                int rowsExtract = endRows - starRows;

               if(checkBoxWallet.Checked)
                {
                    string walletName = textBoxWallet.Text;
                    WalletAddFile(starRows, endRows, walletName);
                }
                if (checkBoxData.Checked)
                {
                    int columnIndexData = Convert.ToInt32(ColumnIndexData.Text);
                    DataColumnAddFile(starRows, endRows, columnIndexData, rowsExtract);
                }
                if (checkBoxCounterparty.Checked)
                {
                    string columnIndexCounterparty = ColumnIndexCounterparty.Text;
                    CounterpartyColumnAddFile(starRows, endRows, columnIndexCounterparty, rowsExtract);
                }
                if (checkBoxSum.Checked)
                {
                    string columnIndexSum = ColumnIndexSum.Text;
                    SumColumnAddFile(starRows, endRows, columnIndexSum, rowsExtract);
                }
                if (checkBoxPurpouse.Checked)
                {
                    int columnIndexPurpouse = Convert.ToInt32(ColumnIndexPurpouse.Text);
                    PurpouseColumnAddFile(starRows, endRows, columnIndexPurpouse, rowsExtract);
                }
                MessageBox.Show("Данные успешно обновлены во втором файле.");
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
                return;
            }
        }

       
        private void WalletAddFile(int starRows,int endRows,string walletName)
        {
            using (var excelPackage = new ExcelPackage(new System.IO.FileInfo(PuthDirectory)))
            {
                // Получаем первый лист из файла
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                // Находим индекс столбца с названием "Кошелек"
                int columnIndex = 0;
                for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                {
                    if (worksheet.Cells[2, col].Value?.ToString() == DictionaryOfWords.columnNameWallet)
                    {
                        columnIndex = col;
                        break;
                    }
                }

                if (columnIndex == 0)
                {
                    Console.WriteLine($"Столбец '{DictionaryOfWords.columnNameWallet}' не найден.");
                    throw new InvalidOperationException($"Столбец '{DictionaryOfWords.columnNameWallet}' не найден.");
                }
                

                // Находим первую пустую строку в столбце "Кошелек"
                int emptyRowIndex = 2;
                while (emptyRowIndex <= worksheet.Dimension.Rows && worksheet.Cells[emptyRowIndex, columnIndex].Value != null)
                {
                    emptyRowIndex++;
                }

                // Добавляем новые строки, начиная с первой пустой строки
                for (int i = 0; i < endRows-starRows +1 ; i++)
                {
                    worksheet.Cells[emptyRowIndex + i, columnIndex].Value = walletName; // Замените "Новое значение" на нужное вам значение
                }

                // Сохраняем изменения в файле
                excelPackage.Save();

            }
        }

        private void DataColumnAddFile(int starRows, int endRows, int columnIndexColumn, int rowsExtract)
        {
            string[] massiv = GetMassiv(starRows, endRows, columnIndexColumn);


            using (var excelPackage = new ExcelPackage(new System.IO.FileInfo(PuthDirectory)))
            {
                // Получаем первый лист из файла
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                // Находим индекс столбца с названием "Дата"
                int columnIndex = 0;
                for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                {
                    if (worksheet.Cells[2, col].Value?.ToString() == DictionaryOfWords.columnNameData)
                    {
                        columnIndex = col;
                        break;
                    }
                }

                if (columnIndex == 0)
                {
                    Console.WriteLine($"Столбец '{DictionaryOfWords.columnNameData}' не найден.");
                    throw new InvalidOperationException($"Столбец '{DictionaryOfWords.columnNameData}' не найден.");
                }

                // Находим первую пустую строку в столбце "Дата"
                int emptyRowIndex = 2;
                while (emptyRowIndex <= worksheet.Dimension.Rows && worksheet.Cells[emptyRowIndex, columnIndex].Value != null)
                {
                    emptyRowIndex++;
                }

                // Добавляем новые строки, начиная с первой пустой строки
                for (int i = 0; i < rowsExtract; i++)
                {
                    worksheet.Cells[emptyRowIndex + i, columnIndex].Value = massiv[i]; // Замените "Новое значение" на нужное вам значение
                }

                // Сохраняем изменения в файле
                excelPackage.Save();

            }
        }

        private void PurpouseColumnAddFile(int starRows, int endRows, int columnIndexColumn, int rowsExtract)
        {
            // Получаем значения из текстовых полей
            string[] massiv = GetMassiv(starRows, endRows, columnIndexColumn);

            using (var excelPackage = new ExcelPackage(new System.IO.FileInfo(PuthDirectory)))
            {
                // Получаем первый лист из файла
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                // Находим индекс столбца с названием "Назначения платежа"
                int columnIndex = 0;
                for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                {
                    if (worksheet.Cells[2, col].Value?.ToString() == DictionaryOfWords.columnNamePorpuse)
                    {
                        columnIndex = col;
                        break;
                    }
                }

                if (columnIndex == 0)
                {
                    Console.WriteLine($"Столбец '{DictionaryOfWords.columnNamePorpuse}' не найден.");
                    throw new InvalidOperationException($"Столбец '{DictionaryOfWords.columnNamePorpuse}' не найден.");
                }

                // Находим первую пустую строку в столбце "Назначение платежа"
                int emptyRowIndex = 2;
                while (emptyRowIndex <= worksheet.Dimension.Rows && worksheet.Cells[emptyRowIndex, columnIndex].Value != null)
                {
                    emptyRowIndex++;
                }

                // Добавляем новые строки, начиная с первой пустой строки
                for (int i = 0; i < rowsExtract; i++)
                {
                    worksheet.Cells[emptyRowIndex + i, columnIndex].Value = massiv[i]; // Замените "Новое значение" на нужное вам значение
                }

                // Сохраняем изменения в файле
                excelPackage.Save();

            }
        }

        private void CounterpartyColumnAddFile(int starRows, int endRows, string columnIndexColumn, int rowsExtract)
        {
            string[] str = columnIndexColumn.Trim().Split(',');
            string[] massiv = new string[endRows - starRows + 1];
            string[] massiv2 = new string[endRows - starRows + 1];
            if (str.Length >= 1)
            {
                massiv = GetMassiv(starRows, endRows, Convert.ToInt32(str[0]));
                if (str.Length == 2)
                {
                    massiv2 = GetMassiv(starRows, endRows, Convert.ToInt32(str[1]));
                }
            }
            else
            {
                Console.WriteLine("Ошибка массивов");
                throw new InvalidOperationException($"Ошибка со столбцами контрагентов");
            }

            using (var excelPackage = new ExcelPackage(new System.IO.FileInfo(PuthDirectory)))
            {
                // Получаем первый лист из файла
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                // Находим индекс столбца с названием "Контрагент"
                int columnIndex = 0;
                for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                {
                    if (worksheet.Cells[2, col].Value?.ToString() == DictionaryOfWords.columnNameCounterparty)
                    {
                        columnIndex = col;
                        break;
                    }
                }

                if (columnIndex == 0)
                {
                    Console.WriteLine($"Столбец '{DictionaryOfWords.columnNameCounterparty}' не найден.");
                    throw new InvalidOperationException($"Столбец '{DictionaryOfWords.columnNameCounterparty}' не найден.");
                }

                // Находим первую пустую строку в столбце "Контрагент"
                int emptyRowIndex = 2;
                while (emptyRowIndex <= worksheet.Dimension.Rows && worksheet.Cells[emptyRowIndex, columnIndex].Value != null)
                {
                    emptyRowIndex++;
                }

                // Добавляем новые строки, начиная с первой пустой строки
                for (int i = 0; i < rowsExtract; i++)
                {
                    if (str.Length == 1)
                    {
                        worksheet.Cells[emptyRowIndex + i, columnIndex].Value = massiv[i]; // Замените "Новое значение" на нужное вам значение
                    }
                    if (str.Length == 2)
                    {
                        string[] strings = GetCounterparty(massiv, massiv2);
                        worksheet.Cells[emptyRowIndex + i, columnIndex].Value = strings[i]; // Замените "Новое значение" на нужное вам значение
                    }
                }
                // Сохраняем изменения в файле
                excelPackage.Save();

            }
        }

        private void SumColumnAddFile(int starRows, int endRows, string columnIndexColumn, int rowsExtract)
        {

            // Получаем значения из текстовых полей
            string[] str = columnIndexColumn.Trim().Split(',');
            string[] massiv = new string[endRows - starRows + 1];
            string[] massiv2 = new string[endRows - starRows + 1];
            if (str.Length >= 1)
            {
                massiv = GetMassiv(starRows, endRows, Convert.ToInt32(str[0]));
                if (str.Length == 2)
                {
                    massiv2 = GetMassiv(starRows, endRows, Convert.ToInt32(str[1]));
                }
            }
            else
            {
                Console.WriteLine("Ошибка массивов");
                throw new InvalidOperationException("Ошибка со столбцами контрагентов");
            }

            using (var excelPackage = new ExcelPackage(new System.IO.FileInfo(PuthDirectory)))
            {
                // Получаем первый лист из файла
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                // Находим индекс столбца с названием "Сумма"
                int columnIndex = 0;
                for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                {
                    if (worksheet.Cells[2, col].Value?.ToString() ==DictionaryOfWords.columnNameSum)
                    {
                        columnIndex = col;
                        break;
                    }
                }

                if (columnIndex == 0)
                {
                    Console.WriteLine($"Столбец '{DictionaryOfWords.columnNameSum}' не найден.");
                    throw new InvalidOperationException($"Столбец '{DictionaryOfWords.columnNameSum}' не найден.");
                }

                // Находим первую пустую строку в столбце "Сумма"
                int emptyRowIndex = 2;
                while (emptyRowIndex <= worksheet.Dimension.Rows && worksheet.Cells[emptyRowIndex, columnIndex].Value != null)
                {
                    emptyRowIndex++;
                }

                // Добавляем новые строки, начиная с первой пустой строки
                for (int i = 0; i < rowsExtract; i++)
                {
                    if (str.Length == 1)
                    {
                        worksheet.Cells[emptyRowIndex + i, columnIndex].Value = massiv[i]; // Замените "Новое значение" на нужное вам значение
                    }
                    if (str.Length == 2)
                    {
                        string[] ints = GetSum(massiv, massiv2);
                        worksheet.Cells[emptyRowIndex + i, columnIndex].Value = ints[i]; // Замените "Новое значение" на нужное вам значение
                    }
                }
                // Сохраняем изменения в файле
                excelPackage.Save();
            }

        }

        private string[] GetMassiv(int start, int end, int ColumnIndex)
        {
            string[] dataRows = new string[end - start + 1];

            // Заполняем массив данными из указанных строк DataGridView
            for (int i = start; i <= end; i++)
            {
                // Здесь предполагается, что вам нужно получить данные из определенного столбца
                // в вашем DataGridView. Замените "ColumnIndex" на индекс нужного столбца.
                dataRows[i - start] = dataGridView1.Rows[i].Cells[ColumnIndex].Value?.ToString().Trim();
            }
            return dataRows;
        }

        private static string[] GetSum(string[] mas1, string[] mas2)
        {
            // Объединение массивов и удаление элементов, содержащих пустую строку
            List<string> resultList = new List<string>();
            resultList.AddRange(mas1.Where(item => !string.IsNullOrEmpty(item)));
            resultList.AddRange(mas2.Where(item => !string.IsNullOrEmpty(item)));

            return resultList.ToArray();
        }

        private string[] GetCounterparty(string[] mas1, string[] mas2)
        {
            // Объединение массивов и удаление элементов, содержащих значение "wallet" в любом месте строки
            List<string> resultList = new List<string>();
            resultList.AddRange(mas1.Where(item => !item.Contains(textBoxWallet.Text)));
            resultList.AddRange(mas2.Where(item => !item.Contains(textBoxWallet.Text)));

            return resultList.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3(PuthDirectory,PuthExtract,PuthKey).ShowDialog();
        }
    }
}
