using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinansistWF
{
    public partial class FormKeyCreate : Form
    {
        private readonly string PuthKey;
        private readonly List<string[]> DataListCount;
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;

        public FormKeyCreate(string PuthKey, List<string[]> DataListCount)
        {
            this.PuthKey = PuthKey;
            this.DataListCount = DataListCount;
            InitializeComponent();
        }

        private void FormKeyCount_Load(object sender, EventArgs e)
        {
            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Open(PuthKey);
            worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            HelperWinForms.ReadExcelData(PuthKey, dataGridView2);
            DisplayDataInDataGridView(DataListCount);
        }

        private void DisplayDataInDataGridView(List<string[]> dataList)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "ContractedColumn", HeaderText = "Contracted" },
                new DataGridViewTextBoxColumn { Name = "DescriptionColumn", HeaderText = "Description" },
                new DataGridViewTextBoxColumn { Name = "ExtractColumn", HeaderText = "Extract" },
                new DataGridViewTextBoxColumn { Name = "Pair", HeaderText = "Pair" });

            foreach (string[] rowData in dataList)
            {
                dataGridView1.Rows.Add(rowData);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxCounter.Text = row.Cells[0].Value.ToString();
                textBoxDiscription.Text = row.Cells[1].Value.ToString();
                textBoxDogovor.Text = row.Cells[1].Value.ToString();
                textBoxArticle.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) => AddKey(textBoxCounter.Text, textBoxDiscription.Text, textBoxDogovor.Text, textBoxArticle.Text);

        private void button2_Click(object sender, EventArgs e) => DeleteKey(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

        private void AddKey(string counter, string description, string dogovor, string article)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Workbook excelWorkbook = null;
            try
            {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelWorkbook = excelApp.Workbooks.Open(PuthKey);
                Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                // Находим первую пустую строку
                int firstEmptyRow = HelperWinForms.FindFirstEmptyRow(excelWorksheet);

                // Добавляем данные в первую пустую строку
                excelWorksheet.Cells[firstEmptyRow, 1] = counter;
                excelWorksheet.Cells[firstEmptyRow, 2] = description;
                excelWorksheet.Cells[firstEmptyRow, 3] = dogovor;
                excelWorksheet.Cells[firstEmptyRow, 4] = article;

                // Сохраняем и закрываем книгу
                excelWorkbook.Save();
                excelWorkbook.Close();
                excelApp.Quit();

                HelperWinForms.ReadExcelData(PuthKey, dataGridView2); //обновляет данные в датагриде этого файла

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteKey(int id)
        {
            //    try
            //    {
            //        Excel.Range usedRange = worksheet.UsedRange;
            //        object[,] data = usedRange.Value2;
            //        int rowCount = data.GetLength(0);
            //        int rowToDelete = -1;

            //        for (int i = 1; i <= rowCount; i++)
            //        {
            //            if (data[i, 1] != null && int.TryParse(data[i, 1].ToString(), out int cellValue))
            //            {
            //                if (cellValue == id)
            //                {
            //                    rowToDelete = i;
            //                    break;
            //                }
            //            }
            //        }

            //        if (rowToDelete != -1)
            //        {
            //            Excel.Range row = (Excel.Range)worksheet.Rows[rowToDelete];
            //            row.Delete();
            //            workbook.Save();
            //            workbook.Close(); // закрываем книгу Excel
            //            excelApp.Quit(); // выходим из приложения Excel

            //            HelperWinForms.ReadExcelData(PuthKey, dataGridView2);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

    }
}
