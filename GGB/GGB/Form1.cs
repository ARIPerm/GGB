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

            Presentor presentor = new Presentor();
            presentor.AttachView(this);
        }


        public string selectedUniversity { get { return comboUniversity.Text;} }

        public List<string> setUniversity { set { comboUniversity.Items.Add(value); } }

        public string averageRating { get { return  } }

        public event EventHandler SavePdfClick;
        public event EventHandler GetRequestStudentUniversity;

        public void MessageError(string message)
        {
            MessageBox.Show(message);
        }

        public void OnSuccessRequest(List<Student> students)
        {
            //TODO: выводим сообщение об успешном выполнение запроса, выводим в текстбокс результаты запроса
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
    }
}
