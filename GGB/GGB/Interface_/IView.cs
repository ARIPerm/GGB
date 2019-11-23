using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IView
    {
        void Message(string message);

        void OnSuccessRequest(List<Student> students, List<string> title);
        
        void SaveFileDialog(string format);

        void VisibleButtonSaveExcel();

        void SetLanguage(IUserString userString);

        //кнопки события, что пользователь нажал кнопку запроса
        event EventHandler GetRequestStudentUniversity;
        event EventHandler GetRequestAverageRating;

        event EventHandler SavePdfClick;
        event EventHandler SaveExcelClick;

        event EventHandler СhangeLanguage;

        //получаем от пользователя текст запроса, через форму

        string SelectedUniversity { get; }

        string AverageRating { get; }
        
        string PathGet { get; }

        IList<string> SetUniversity { set; }

        string SelectedLanguage { get; }

    }
}
