using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGB
{
    public partial class MainView : Form, IView
    {    
        public MainView()
        {
            InitializeComponent();

            Presentor presentor = new Presentor(new SavePDF(), new SaveExcel(), new Model(), new UserString(new YandexTranslate()));
            presentor.AttachView(this);

            comboBox2.Items.AddRange(Constant.comboLanguage);

        }

        private string path;

        public string SelectedUniversity { get { return comboUniversity.Text;} }
        public List<string> SetUniversity { set { comboUniversity.Items.Add(value); comboBoxUniversity.Items.Add(value); } }
        public string AverageRating { get { return comboRatingAverage.Text; } }              
        public string PathGet { get { return path; } }
        public string SelectedLanguage { get { return comboBox2.Text; } }



        public event EventHandler SavePdfClick;
        public event EventHandler SaveExcelClick;
        public event EventHandler GetRequestStudentUniversity;
        public event EventHandler GetRequestAverageRating;
        public event EventHandler СhangeLanguage;

        private void WriteDataGrid (List<Student> students, List<string> title)
        {
            dataGridView1.ColumnCount = title.Count-1;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = title[i];
                dataGridView1.Columns[i].ReadOnly = true;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows.Add(students[i].GetName, students[i].GetPatronymic, students[i].GetSurname);
        }

        public void VisibleButtonSaveExcel ()
        {
            saveExcel.Visible = false;
        }

        public void SaveFileDialog(string format)
        {
            if (format == Constant.formatPdf)
            {
                saveFileDialog1.Filter = "Text files(*.pdf)|*.pdf";
            }
            else
                if (format == Constant.formatExcel)
                    saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                path = null;
                return;
            }
            else
                path = saveFileDialog1.FileName;       
        }
        
        public void Message(string message)
        {
            MessageBox.Show(message);
        }

        public void OnSuccessRequest(List<Student> students, List<string> title)
        {
            MessageBox.Show(Constant.onSuccessRequestMessage);

            dataGridView1.Rows.Clear();
            WriteDataGrid(students, title);
        }

        private void savePdf_Click(object sender, EventArgs e)
        {
            if (SavePdfClick != null)
                SavePdfClick(this, EventArgs.Empty);
        }

        private void requestStudentUniversity_Click(object sender, EventArgs e)
        {
            if (GetRequestStudentUniversity != null)
                GetRequestStudentUniversity(this, EventArgs.Empty);
        }

        private void saveExcel_Click(object sender, EventArgs e)
        {
            if (SaveExcelClick != null)
                SaveExcelClick(this, EventArgs.Empty);
        }

        private void requestAverageRating_Click(object sender, EventArgs e)
        {
            if (GetRequestAverageRating != null)
                GetRequestAverageRating(this, EventArgs.Empty);
        }

        public void SetLanguage(IUserString userString)
        {
            savePdf.Text = userString.buttonSavePdf;
            saveExcel.Text = userString.buttonSaveExcel;

            requestAverageRating.Text = userString.buttonNameRequest;
            requestStudentUniversity.Text = userString.buttonNameRequest;

            label1.Text = userString.university;
            label2.Text = userString.ratingAverage;
            label3.Text = userString.university;
            label4.Text = userString.selectedLanguage;

            groupBox1.Text = userString.nameRequestUniversity;
            groupBox2.Text = userString.nameRequestRating;

            //comboBox2.Items.Clear();
            //comboBox2.Items.AddRange(Constant.comboLanguage);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (СhangeLanguage != null)
                СhangeLanguage(this, EventArgs.Empty);
        }
    }
}
