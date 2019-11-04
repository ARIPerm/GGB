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

        public string requestText => throw new NotImplementedException();

        public event EventHandler GetRequestClick;
        public event EventHandler SavePdfClick;

        public void MessageError(string message)
        {
            MessageBox.Show(message);
        }

        public void OnSuccessRequest()
        {
            throw new NotImplementedException();
        }

        private void savePdf_Click(object sender, EventArgs e)
        {
            if (SavePdfClick != null)
                SavePdfClick(this, EventArgs.Empty);
        }
    }
}
