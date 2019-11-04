using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Presentor: ErrorListener
    {
        IView view;
        ISavePDF savePdf;

        public Presentor()
        {
            savePdf = new SavePDF();

            savePdf.setErrorListener(this);
        }


        public void AttachView (IView view)
        {
            this.view = view;

            view.SavePdfClick += View_SavePdfClick;
        }

        public void OnError(string message)
        {
            view.MessageError("Ошибка при сохранении");
        }

        private void View_SavePdfClick(object sender, EventArgs e)
        {          
            savePdf.Save(null, null, null);
        }
    }
}
