using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace FinansistWF
{
    abstract class HelperWinForms
    {
        public static void ReadExcelData(string filePath, DataGridView dataGridView1)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Workbook excelWorkbook = null;

            try
            {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelWorkbook = excelApp.Workbooks.Open(filePath);
                Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                Range usedRange = excelWorksheet.UsedRange;
                object[,] data = usedRange.Value2;

                int rowCountExtract = data.GetLength(0);
                int columnCountDirectory = data.GetLength(1);

                DataTable dt = new DataTable();

                // Добавляем первую колонку для индекса строки
                dt.Columns.Add("Index");

                // Добавляем колонки для данных из Excel
                for (int i = 1; i <= columnCountDirectory; i++)
                {
                    dt.Columns.Add("Column " + i);
                }

                // Заполняем таблицу данными из Excel
                for (int i = 1; i <= rowCountExtract; i++)
                {
                    DataRow dr = dt.NewRow();

                    // Заполняем первую колонку индексами строк
                    dr[0] = i;

                    for (int j = 1; j <= columnCountDirectory; j++)
                    {
                        if (data[i, j] != null)
                        {
                            dr[j] = data[i, j];
                        }
                        else
                        {
                            dr[j] = DBNull.Value;
                        }
                    }
                    dt.Rows.Add(dr);
                }

                dataGridView1.Invoke(new MethodInvoker(delegate
                {
                    dataGridView1.DataSource = dt;
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при установке источника данных для DataGridView: {ex.Message}");
            }
            finally
            {
                if (excelWorkbook != null)
                {
                    excelWorkbook.Close(); // Явное закрытие книги перед освобождением ресурсов
                    Marshal.ReleaseComObject(excelWorkbook);
                }

                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }


        public static int FindFirstEmptyRow(Worksheet worksheet)
        {
            int row = 1;
            while (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Text))
            {
                row++;
            }
            return row;
        }
    }
}
