namespace FinansistWF
{
    partial class FormDdsHub
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDirectoruFile = new System.Windows.Forms.Button();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.buttonExtractFormOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDirectoruFile
            // 
            this.buttonDirectoruFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDirectoruFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDirectoruFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDirectoruFile.Location = new System.Drawing.Point(55, 61);
            this.buttonDirectoruFile.Name = "buttonDirectoruFile";
            this.buttonDirectoruFile.Size = new System.Drawing.Size(154, 75);
            this.buttonDirectoruFile.TabIndex = 0;
            this.buttonDirectoruFile.Text = "Добавить реестр ";
            this.buttonDirectoruFile.UseVisualStyleBackColor = false;
            this.buttonDirectoruFile.Click += new System.EventHandler(this.buttonDirectoruFile_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.Location = new System.Drawing.Point(749, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(41, 24);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // buttonExtractFormOpen
            // 
            this.buttonExtractFormOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExtractFormOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtractFormOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExtractFormOpen.Location = new System.Drawing.Point(238, 61);
            this.buttonExtractFormOpen.Name = "buttonExtractFormOpen";
            this.buttonExtractFormOpen.Size = new System.Drawing.Size(154, 75);
            this.buttonExtractFormOpen.TabIndex = 3;
            this.buttonExtractFormOpen.Text = "Добавить выписку";
            this.buttonExtractFormOpen.UseVisualStyleBackColor = false;
            this.buttonExtractFormOpen.Click += new System.EventHandler(this.buttonExtractFormOpen_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(55, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Создать ключи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(238, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "Заполнить реестр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(442, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 75);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавить ключи";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExtractFormOpen);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.buttonDirectoruFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDirectoruFile;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Button buttonExtractFormOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

