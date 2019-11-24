using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGB.View_
{
    public partial class TestForm : Form
    {
        public Button but = new Button();
        public TestForm()
        {
            InitializeComponent();
            but.Text = "My Button";
            but.Size = new Size(60, 20);
            but.Location = new Point(10, 10);
            ///////////////////////////////////////Click
            but.Click += new EventHandler(but_Click);
            this.Controls.Add(but);
        }
        ////////////////////////Обработка Click
        private void but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Welcome");
        }
    }
}
