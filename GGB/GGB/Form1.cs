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
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();

            Presentor presentor = new Presentor(new SavePDF(), new SaveExcel());
            presentor.AttachView(this);
        }


        public string selectedUniversity { get { return comboUniversity.Text;} }

        public List<string> setUniversity { set { comboUniversity.Items.Add(value); } }

        public string averageRating { get { return ratingAverage.Text; } }
        
        private string path;
        
        public string pathGet {get { return path; } }


        public event EventHandler SavePdfClick;
        public event EventHandler SaveExcelClick;
        public event EventHandler GetRequestStudentUniversity;
        public event EventHandler GetRequestAverageRating;

        public void VisibleButtonSaveExcel ()
        {
            saveExcel.Visible = false;
        }

        public void SaveFileDialog()
        {
            saveFileDialog1.Filter = "Text files(*.pdf)|*.pdf | Excel (*.xsl)|*.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                path = null;
                return;
            }
            else
                path = saveFileDialog1.FileName;       
        }
        
        public void MessageError(string message)
        {
            MessageBox.Show(message);
        }

        public void OnSuccessRequest(List<Student> students)
        {
            //TODO: выводим сообщение об успешном выполнение запроса, выводим в текстбокс результаты запроса
            MessageBox.Show("Запрос выполнен успешно");
            
            
            
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
    }
}
