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
        IModel model;
        IUserString userString;

        public Presentor(ISavePDF savePdf, ISaveExcel saveExcel, IModel model, IUserString userString)
        {
            this.savePdf = savePdf;
            this.saveExcel = saveExcel;
            this.model = model;
            this.userString = userString;

            savePdf.setErrorListener(this);
            saveExcel.setErrorListener(this); 
        }

        public void AttachView (IView view)
        {
            this.view = view;
            view.SetLanguage(userString);
            

            if (model.GetNameUniversity != null)
                view.SetUniversity = model.GetNameUniversity;
            
            if (saveExcel.ExistenceExcel())
                view.VisibleButtonSaveExcel();
                
            view.SavePdfClick += View_SavePdfClick;
            view.SaveExcelClick += View_SaveExcelClick;
            view.GetRequestStudentUniversity += View_GetRequestStudentUniversity;
            view.GetRequestAverageRating += View_GetRequestAverageRating;
            view.СhangeLanguage += View_СhangeLanguage;

        }

        private void View_СhangeLanguage(object sender, EventArgs e)
        {
            userString.SetLanguage(view.SelectedLanguage);
            view.SetLanguage(userString);
        }

        private void View_GetRequestAverageRating(object sender, EventArgs e)
        {
            List<string> title = new List<string>();
            title.Add("ID");
            title.Add("Name");
            title.Add("Surname");
            title.Add("Patronymic");
            title.Add("AverageRating");
            model.RequestGetStudentRatingAverage(view.SelectedUniversityBox, view.AverageRating);
            view.OnSuccessRequest((List<Student>)model.GetStudent, title);
        }

        private void View_SaveExcelClick(object sender, EventArgs e)
        {
            view.SaveFileDialog(Constant.formatExcel);
            
            saveExcel.Save(view.PathGet, null, null,null);
            //TODO: проверка что успешно сохранено и вывод сообщение пользователю
            //view.Message(Constant.onSuccessSaveMessage);
        }

        private void View_GetRequestStudentUniversity(object sender, EventArgs e)
        {
            model.RequestGetStudentUniversity(view.SelectedUniversity);

            List<string> title = new List<string>();
            title.Add("ID");
            title.Add("Name");
            title.Add("Surname");
            title.Add("Patronymic");

            view.OnSuccessRequest((List<Student>)model.GetStudent, title);
        }

        public void OnError(string message)
        {
            view.Message(message);
        }

        private void View_SavePdfClick(object sender, EventArgs e)
        {
            view.SaveFileDialog(Constant.formatPdf);

            savePdf.Save(view.PathGet, null, null);
            //TODO: проверка что успешно сохранено и вывод сообщение пользователю
            //view.Message(Constant.onSuccessSaveMessage);
        }
    }
}
