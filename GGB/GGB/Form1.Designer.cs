namespace GGB
{
    partial class Form1
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
            this.savePdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requestStudentUniversity = new System.Windows.Forms.Button();
            this.comboUniversity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.ratingAverage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // savePdf
            // 
            this.savePdf.Location = new System.Drawing.Point(236, 375);
            this.savePdf.Name = "savePdf";
            this.savePdf.Size = new System.Drawing.Size(118, 23);
            this.savePdf.TabIndex = 0;
            this.savePdf.Text = "Сохранить в pdf";
            this.savePdf.UseVisualStyleBackColor = true;
            this.savePdf.Click += new System.EventHandler(this.savePdf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.requestStudentUniversity);
            this.groupBox1.Controls.Add(this.comboUniversity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запрос по университетам";
            // 
            // requestStudentUniversity
            // 
            this.requestStudentUniversity.Location = new System.Drawing.Point(22, 70);
            this.requestStudentUniversity.Name = "requestStudentUniversity";
            this.requestStudentUniversity.Size = new System.Drawing.Size(160, 23);
            this.requestStudentUniversity.TabIndex = 2;
            this.requestStudentUniversity.Text = "Получить список студентов";
            this.requestStudentUniversity.UseVisualStyleBackColor = true;
            this.requestStudentUniversity.Click += new System.EventHandler(this.requestStudentUniversity_Click);
            // 
            // comboUniversity
            // 
            this.comboUniversity.FormattingEnabled = true;
            this.comboUniversity.Location = new System.Drawing.Point(45, 43);
            this.comboUniversity.Name = "comboUniversity";
            this.comboUniversity.Size = new System.Drawing.Size(137, 21);
            this.comboUniversity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Университет";
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(236, 12);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(261, 299);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.Text = "";
            // 
            // ratingAverage
            // 
            this.ratingAverage.Location = new System.Drawing.Point(84, 184);
            this.ratingAverage.Name = "ratingAverage";
            this.ratingAverage.Size = new System.Drawing.Size(100, 20);
            this.ratingAverage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Средний рейтинг не менее";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.ratingAverage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savePdf);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button savePdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button requestStudentUniversity;
        private System.Windows.Forms.ComboBox comboUniversity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.TextBox ratingAverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

