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


        SavePDF save;
        Presentor presentor;

        public event EventHandler Button_Click;

        public Form1()
        {
            InitializeComponent();


             save = new SavePDF();
             presentor = new Presentor(this);
        }


        public void MessageError(string message)
        {
            MessageBox.Show(message);
        }

        public void OnSuccessRequest()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Button_Click != null)
                Button_Click(this, EventArgs.Empty);
        }
    }
}
