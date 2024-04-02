using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansistWF
{
    public partial class FormExtractOld : Form
    {
        private string Directory;
        private string PuthKey;
        public FormExtractOld(string Directory, string PuthKey)
        {
            this.Directory = Directory;
            this.PuthKey = PuthKey;
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();       
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDdsHub().ShowDialog();
        }
        private void Form4_Load(object sender, EventArgs e) => HelperWinForms.ReadExcelData(Directory, dataGridView1);

        private void button1_Click(object sender, EventArgs e)
        {
            int IndexStart = Convert.ToInt32(NumberStart.Text);
            int IndexEnd = Convert.ToInt32(NumberEnd.Text);
            int IndexContracted = Convert.ToInt32(ColumnIndexContracted.Text);
            int IndexDescription = Convert.ToInt32(ColumnIndexDescription.Text);
            int IndexExstract = Convert.ToInt32(ColumnIndexExstract.Text);
            List<string[]> DataList = ReadDataFromDGV(IndexStart,IndexEnd,IndexContracted, IndexDescription, IndexExstract);
            List<string[]> DataListCount = CountMatches(DataList);
            this.Hide();
            new FormKeyCreate(PuthKey, DataListCount).ShowDialog();
        }

        private List<string[]> ReadDataFromDGV(int startRowIndex, int endRowIndex, int contractedColumnIndex, int descriptionColumnIndex, int extractColumnIndex)
        {
            List<string[]> dataList = new List<string[]>();

            // Проверяем, чтобы индексы начала и конца были корректными
            if (startRowIndex < 0 || endRowIndex >= dataGridView1.Rows.Count || startRowIndex > endRowIndex)
            {
                MessageBox.Show("Некорректные индексы начала и конца.");
                return dataList;
            }

            // Проходим по строкам DataGridView и считываем данные
            for (int i = startRowIndex; i <= endRowIndex; i++)
            {
                // Получаем значения из указанных столбцов
                string contracted = dataGridView1.Rows[i].Cells[contractedColumnIndex].Value?.ToString();
                string description = dataGridView1.Rows[i].Cells[descriptionColumnIndex].Value?.ToString();
                string extract = dataGridView1.Rows[i].Cells[extractColumnIndex].Value?.ToString();

                // Создаем массив с данными из строки
                string[] rowData = new string[] { contracted, description, extract };

                // Добавляем массив в список данных
                dataList.Add(rowData);
            }

            return dataList;
        }

        private List<string[]> CountMatches(List<string[]> dataList)
        {
            // Создаем словарь для подсчета совпадений
            Dictionary<string, int> matchCounts = new Dictionary<string, int>();

            // Проходим по данным в dataList и подсчитываем количество совпадений
            foreach (string[] rowData in dataList)
            {
                // Составляем уникальный ключ на основе контрагента, описания и статьи
                string key = $"{rowData[0]}|{rowData[1]}|{rowData[2]}";

                // Если ключ уже присутствует в словаре, увеличиваем счетчик
                if (matchCounts.ContainsKey(key))
                {
                    matchCounts[key]++;
                }
                // В противном случае, добавляем новую запись в словарь
                else
                {
                    matchCounts[key] = 1;
                }
            }

            // Создаем новый список для хранения данных с количеством совпадений
            List<string[]> newDataList = new List<string[]>();

            // Проходим по словарю и добавляем данные в новый список
            foreach (var pair in matchCounts)
            {
                // Разбиваем ключ обратно на контрагент, описание и статью
                string[] values = pair.Key.Split('|');

                // Создаем новую строку, добавляя количество совпадений в конец
                string[] newRowData = new string[] { values[0], values[1], values[2], pair.Value.ToString() };

                // Добавляем строку в новый список
                newDataList.Add(newRowData);
            }

            return newDataList;
        }

    }
}
