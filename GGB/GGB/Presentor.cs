using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GGB.Presentor;

namespace GGB
{
    public class Presentor : ErrorListener
    {

        Publisher publisher;

        IView view;
        SavePDF save;


        public Presentor(IView view)
        {

            this.view = view;
            publisher = new Publisher();
            save = new SavePDF();
            save.setErrorListener(this);
            publisher.errorSaveEvent += Publisher_errorSaveEvent;

            view.Button_Click += View_Button_Click;
            
        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            save.Save(null, null, null);
        }

        public void test()
        {
            save.Save(null, null, null);
        }

        public void OnError(string message)
        {
            view.MessageError("Error");
        }

        private void Publisher_errorSaveEvent(object sender, EventArgs e)
        {
            view.MessageError("Error");
        }

        public interface ErrorListener
        {
            void OnError(string message);
        }
        

    }
}
