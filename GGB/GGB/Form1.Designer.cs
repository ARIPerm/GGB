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
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboRatingAverage = new System.Windows.Forms.ComboBox();
            this.requestAverageRating = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // savePdf
            // 
            this.savePdf.Location = new System.Drawing.Point(265, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(280, 421);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Средний рейтинг не менее";
            // 
            // saveExcel
            // 
            this.saveExcel.Location = new System.Drawing.Point(389, 29);
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Size = new System.Drawing.Size(118, 23);
            this.saveExcel.TabIndex = 5;
            this.saveExcel.Text = "Сохранить в Excel";
            this.saveExcel.UseVisualStyleBackColor = true;
            this.saveExcel.Click += new System.EventHandler(this.saveExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 357);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboRatingAverage);
            this.groupBox2.Controls.Add(this.requestAverageRating);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(66, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 151);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запрос по рейтингу";
            // 
            // comboRatingAverage
            // 
            this.comboRatingAverage.FormattingEnabled = true;
            this.comboRatingAverage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboRatingAverage.Location = new System.Drawing.Point(79, 88);
            this.comboRatingAverage.Name = "comboRatingAverage";
            this.comboRatingAverage.Size = new System.Drawing.Size(103, 21);
            this.comboRatingAverage.TabIndex = 8;
            // 
            // requestAverageRating
            // 
            this.requestAverageRating.Location = new System.Drawing.Point(22, 122);
            this.requestAverageRating.Name = "requestAverageRating";
            this.requestAverageRating.Size = new System.Drawing.Size(160, 23);
            this.requestAverageRating.TabIndex = 2;
            this.requestAverageRating.Text = "Получить список студентов";
            this.requestAverageRating.UseVisualStyleBackColor = true;
            this.requestAverageRating.Click += new System.EventHandler(this.requestAverageRating_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Университет";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Английский",
            "Русский"});
            this.comboBox2.Location = new System.Drawing.Point(37, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savePdf);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button savePdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button requestStudentUniversity;
        private System.Windows.Forms.ComboBox comboUniversity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboRatingAverage;
        private System.Windows.Forms.Button requestAverageRating;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
    }
}

