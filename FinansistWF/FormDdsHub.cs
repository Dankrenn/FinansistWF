using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace FinansistWF
{
    public partial class FormDdsHub : Form
    {
        private string nameDirectory;
        private string nameExtands;
        private string nameKey;
        public FormDdsHub()
        {
            InitializeComponent();
        }

        private void buttonDirectoruFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nameDirectory = openFileDialog.FileName;
                buttonDirectoruFile.BackColor = Color.Green;
            }
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonExtractFormOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nameExtands = openFileDialog.FileName;
                buttonExtractFormOpen.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nameDirectory ==null)
            {
                MessageBox.Show("Добавьте реестр");
            }
            if (nameKey == null)
            {
                MessageBox.Show("Добавьте ключи");
            }
            else
            {
                this.Hide();
                new FormExtractOld(nameDirectory,nameKey).ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nameDirectory == null)
            {
                MessageBox.Show("Добавьте реестр");
            }
            if (nameExtands == null)
            {
                MessageBox.Show("Добавьте выписку");
            }
            if (nameKey == null)
            {
                MessageBox.Show("Добавьте ключи");
            }
            else
            {
                this.Hide();
                new FormExtract(nameExtands, nameDirectory,nameKey).ShowDialog();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nameKey = openFileDialog.FileName;
                button3.BackColor = Color.Green;
            }
        }
    }


}
