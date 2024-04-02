namespace FinansistWF
{
    partial class FormExtractOld
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIndexExstract = new System.Windows.Forms.TextBox();
            this.ColumnIndexDescription = new System.Windows.Forms.TextBox();
            this.ColumnIndexContracted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberEnd = new System.Windows.Forms.TextBox();
            this.NumberStart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(715, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назад";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(783, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 509);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColumnIndexExstract
            // 
            this.ColumnIndexExstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnIndexExstract.Location = new System.Drawing.Point(747, 239);
            this.ColumnIndexExstract.Name = "ColumnIndexExstract";
            this.ColumnIndexExstract.Size = new System.Drawing.Size(71, 29);
            this.ColumnIndexExstract.TabIndex = 44;
            // 
            // ColumnIndexDescription
            // 
            this.ColumnIndexDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnIndexDescription.Location = new System.Drawing.Point(747, 185);
            this.ColumnIndexDescription.Name = "ColumnIndexDescription";
            this.ColumnIndexDescription.Size = new System.Drawing.Size(71, 29);
            this.ColumnIndexDescription.TabIndex = 43;
            // 
            // ColumnIndexContracted
            // 
            this.ColumnIndexContracted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnIndexContracted.Location = new System.Drawing.Point(747, 133);
            this.ColumnIndexContracted.Name = "ColumnIndexContracted";
            this.ColumnIndexContracted.Size = new System.Drawing.Size(71, 29);
            this.ColumnIndexContracted.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(508, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Номер колонки статьи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(508, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 40;
            this.label3.Text = "Номер колонки \r\nназначения платежа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(508, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Номер колонки контрагента";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 45;
            this.button1.Text = "Создать ключи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(620, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 40);
            this.label7.TabIndex = 49;
            this.label7.Text = "Конечная \r\nстрока";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(505, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 40);
            this.label6.TabIndex = 48;
            this.label6.Text = "Начальная \r\nстрока";
            // 
            // NumberEnd
            // 
            this.NumberEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberEnd.Location = new System.Drawing.Point(624, 83);
            this.NumberEnd.Name = "NumberEnd";
            this.NumberEnd.Size = new System.Drawing.Size(71, 29);
            this.NumberEnd.TabIndex = 47;
            // 
            // NumberStart
            // 
            this.NumberStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberStart.Location = new System.Drawing.Point(520, 83);
            this.NumberStart.Name = "NumberStart";
            this.NumberStart.Size = new System.Drawing.Size(71, 29);
            this.NumberStart.TabIndex = 46;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(897, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberEnd);
            this.Controls.Add(this.NumberStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColumnIndexExstract);
            this.Controls.Add(this.ColumnIndexDescription);
            this.Controls.Add(this.ColumnIndexContracted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ColumnIndexExstract;
        private System.Windows.Forms.TextBox ColumnIndexDescription;
        private System.Windows.Forms.TextBox ColumnIndexContracted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumberEnd;
        private System.Windows.Forms.TextBox NumberStart;
    }
}