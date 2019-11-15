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
        ISaveExcel saveExcel;
        //IGetDB getBD;
        IModel model;
        ICustomString customString;

        public Presentor(ISavePDF savePdf, ISaveExcel saveExcel, IModel model, ICustomString customString)
        {
            this.savePdf = savePdf;
            this.saveExcel = saveExcel;
            this.model = model;
            this.customString = customString;

            savePdf.setErrorListener(this);
            saveExcel.setErrorListener(this); 
        }


        public void AttachView (IView view)
        {
            this.view = view;
            view.SetLanguage(customString);

            if (model.nameUniversity != null)
                view.setUniversity = model.nameUniversity;
            
            if (saveExcel.InstallExcel())
                view.VisibleButtonSaveExcel();
                
            view.SavePdfClick += View_SavePdfClick;
            view.SaveExcelClick += View_SaveExcelClick;
            view.GetRequestStudentUniversity += View_GetRequestStudentUniversity;
            view.GetRequestAverageRating += View_GetRequestAverageRating;
            view.EditLanguage += View_EditLanguage;

        }

        private void View_EditLanguage(object sender, EventArgs e)
        {
            customString.SetLanguage(view.selectedLanguage);
            view.SetLanguage(customString);
        }

        private void View_GetRequestAverageRating(object sender, EventArgs e)
        {
            
        }

        private void View_SaveExcelClick(object sender, EventArgs e)
        {
            view.SaveFileDialog();

            List<string> titleColumn = new List<string>();
            titleColumn.Add("");



            List<string> data = new List<string>();
            data.Add("vhcgncgn jcyhbn");
            data.Add("vhcgncgn jcyhbn");
            data.Add("vhcgncgn jcyhbn");
            data.Add("vhcgncgn jcyhbn");
            data.Add("vhcgncgn jcyhbn");

            saveExcel.Save(view.pathGet, "title",titleColumn, data);
        }

        private void View_GetRequestStudentUniversity(object sender, EventArgs e)
        {
            //TODO: формируем запрос по данным view.selectedUniversity and view.averageRating
        }

        public void OnError(string message)
        {
            view.MessageError(message);
        }

        private void View_SavePdfClick(object sender, EventArgs e)
        {
            //обработка успешного сохранения и вывод через вью сообщения об успешном сохранении
            view.SaveFileDialog();
            savePdf.Save(view.pathGet, null, null);
        }
    }
}
