namespace FinansistWF
{
    partial class FormExtract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NumberStart = new System.Windows.Forms.TextBox();
            this.NumberEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ColumnIndexData = new System.Windows.Forms.TextBox();
            this.ColumnIndexPurpouse = new System.Windows.Forms.TextBox();
            this.ColumnIndexCounterparty = new System.Windows.Forms.TextBox();
            this.ColumnIndexSum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxWallet = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.checkBoxCounterparty = new System.Windows.Forms.CheckBox();
            this.checkBoxSum = new System.Windows.Forms.CheckBox();
            this.checkBoxPurpouse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.Location = new System.Drawing.Point(974, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(41, 24);
            this.ExitLabel.TabIndex = 3;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 493);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBoxWallet
            // 
            this.textBoxWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWallet.Location = new System.Drawing.Point(506, 106);
            this.textBoxWallet.Name = "textBoxWallet";
            this.textBoxWallet.Size = new System.Drawing.Size(223, 29);
            this.textBoxWallet.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(505, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название кошелька";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(511, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Напишите номер \r\nколонки даты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(511, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 60);
            this.label3.TabIndex = 10;
            this.label3.Text = "Напишите номера колонок \r\nконтрагентов(через \",\") ,\r\nесли она одна оставьте \",\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(511, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 60);
            this.label4.TabIndex = 12;
            this.label4.Text = "Напишите номера колонок \r\nсуммы(через \",\") \r\nесли она одна оставьте \",\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(511, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "Напишите номер колонки \r\nназначения платежа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "ВНЕСТИ ДАННЫЕ В РЕЕСТР";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberStart
            // 
            this.NumberStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberStart.Location = new System.Drawing.Point(750, 106);
            this.NumberStart.Name = "NumberStart";
            this.NumberStart.Size = new System.Drawing.Size(71, 29);
            this.NumberStart.TabIndex = 16;
            // 
            // NumberEnd
            // 
            this.NumberEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberEnd.Location = new System.Drawing.Point(854, 106);
            this.NumberEnd.Name = "NumberEnd";
            this.NumberEnd.Size = new System.Drawing.Size(71, 29);
            this.NumberEnd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(850, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "Конечная \r\nстрока";
            // 
            // ColumnIndexData
            // 
            this.ColumnIndexData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnIndexData.Location = new System.Drawing.Point(750, 175);
            this.ColumnIndexData.Name = "ColumnIndexData";
            this.ColumnIndexData.Size = new System.Drawing.Size(71, 29);
            this.ColumnIndexData.TabIndex = 20;
            // 
            // ColumnIndexPurpouse
            // 
            this.ColumnIndexPurpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnIndexPurpouse.Location = new System.Drawing.Point(750, 391);
            this.ColumnIndexPurpouse.Name = "ColumnIndexPurpouse";
            this.ColumnIndexPurpouse.Size = new System.Drawing.Size(71, 29);
            this.ColumnIndexPurpouse.TabIndex = 26;
            // 
            // ColumnIndexCounterparty
            // 
            this.ColumnIndexCounterparty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnIndexCounterparty.Location = new System.Drawing.Point(750, 234);
            this.ColumnIndexCounterparty.Name = "ColumnIndexCounterparty";
            this.ColumnIndexCounterparty.Size = new System.Drawing.Size(71, 29);
            this.ColumnIndexCounterparty.TabIndex = 32;
            // 
            // ColumnIndexSum
            // 
            this.ColumnIndexSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnIndexSum.Location = new System.Drawing.Point(750, 319);
            this.ColumnIndexSum.Name = "ColumnIndexSum";
            this.ColumnIndexSum.Size = new System.Drawing.Size(71, 29);
            this.ColumnIndexSum.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 53);
            this.button2.TabIndex = 40;
            this.button2.Text = "Далее к статьям";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(735, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 40);
            this.label6.TabIndex = 18;
            this.label6.Text = "Начальная \r\nстрока";
            // 
            // checkBoxWallet
            // 
            this.checkBoxWallet.AutoSize = true;
            this.checkBoxWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWallet.Location = new System.Drawing.Point(931, 106);
            this.checkBoxWallet.Name = "checkBoxWallet";
            this.checkBoxWallet.Size = new System.Drawing.Size(107, 28);
            this.checkBoxWallet.TabIndex = 41;
            this.checkBoxWallet.Text = "Кошелек";
            this.checkBoxWallet.UseVisualStyleBackColor = true;
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxData.Location = new System.Drawing.Point(928, 175);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(73, 28);
            this.checkBoxData.TabIndex = 42;
            this.checkBoxData.Text = "Дата";
            this.checkBoxData.UseVisualStyleBackColor = true;
            // 
            // checkBoxCounterparty
            // 
            this.checkBoxCounterparty.AutoSize = true;
            this.checkBoxCounterparty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCounterparty.Location = new System.Drawing.Point(928, 236);
            this.checkBoxCounterparty.Name = "checkBoxCounterparty";
            this.checkBoxCounterparty.Size = new System.Drawing.Size(148, 28);
            this.checkBoxCounterparty.TabIndex = 43;
            this.checkBoxCounterparty.Text = "Контрагенты";
            this.checkBoxCounterparty.UseVisualStyleBackColor = true;
            // 
            // checkBoxSum
            // 
            this.checkBoxSum.AutoSize = true;
            this.checkBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSum.Location = new System.Drawing.Point(928, 319);
            this.checkBoxSum.Name = "checkBoxSum";
            this.checkBoxSum.Size = new System.Drawing.Size(87, 28);
            this.checkBoxSum.TabIndex = 44;
            this.checkBoxSum.Text = "Сумма";
            this.checkBoxSum.UseVisualStyleBackColor = true;
            // 
            // checkBoxPurpouse
            // 
            this.checkBoxPurpouse.AutoSize = true;
            this.checkBoxPurpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPurpouse.Location = new System.Drawing.Point(928, 391);
            this.checkBoxPurpouse.Name = "checkBoxPurpouse";
            this.checkBoxPurpouse.Size = new System.Drawing.Size(108, 28);
            this.checkBoxPurpouse.TabIndex = 45;
            this.checkBoxPurpouse.Text = "Платежи";
            this.checkBoxPurpouse.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1076, 514);
            this.Controls.Add(this.checkBoxPurpouse);
            this.Controls.Add(this.checkBoxSum);
            this.Controls.Add(this.checkBoxCounterparty);
            this.Controls.Add(this.checkBoxData);
            this.Controls.Add(this.checkBoxWallet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ColumnIndexSum);
            this.Controls.Add(this.ColumnIndexCounterparty);
            this.Controls.Add(this.ColumnIndexPurpouse);
            this.Controls.Add(this.ColumnIndexData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberEnd);
            this.Controls.Add(this.NumberStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWallet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitLabel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumberStart;
        private System.Windows.Forms.TextBox NumberEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ColumnIndexData;
        private System.Windows.Forms.TextBox ColumnIndexPurpouse;
        private System.Windows.Forms.TextBox ColumnIndexCounterparty;
        private System.Windows.Forms.TextBox ColumnIndexSum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxWallet;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxCounterparty;
        private System.Windows.Forms.CheckBox checkBoxSum;
        private System.Windows.Forms.CheckBox checkBoxPurpouse;
    }
}