using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class CustomString : ICustomString
    {
        public string nameRequestUniversity { get; set; }
        public string nameRequestRating { get; set; }
        public string university { get; set; }
        public string ratingAverage { get; set; }
        public string buttonNameRequest { get; set; }
        public string buttonSavePdf { get; set; }
        public string buttonSaveExcel { get; set; }
        public string selectedLanguage { get; set; }

        public void DefaultLanguage()
        {
            nameRequestUniversity = "Запрос по университетам";
            nameRequestRating = "Запрос по рейтингу";

            university = "Выберите университет:";
            ratingAverage = "Средний рейтинг не менее:";

            buttonNameRequest = "Получить список студентов";
            buttonSavePdf = "Сохранить в PDF";
            buttonSaveExcel = "Сохранить в Excel";
        }

        public void SetLanguage(Language language)
        {
            throw new NotImplementedException();
        }
    }
}
