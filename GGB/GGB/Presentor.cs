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
        IGetDB getBD;

        public Presentor()
        {
            savePdf = new SavePDF();

            savePdf.setErrorListener(this);
            
        }




        public void AttachView (IView view)
        {
            this.view = view;
            //TODO: надо из бд взять список университетов и добавить его в комбобокс на вью 
            //view.setUniversity(university);

            view.SavePdfClick += View_SavePdfClick;
            view.GetRequestStudentUniversity += View_GetRequestStudentUniversity;
        }

        private void View_GetRequestStudentUniversity(object sender, EventArgs e)
        {
            //TODO: формируем запрос по данным view.selectedUniversity and view.averageRating
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
