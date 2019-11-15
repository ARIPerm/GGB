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

        IYandexTranslate yandexTranslate;

        public CustomString(IYandexTranslate yandexTranslate)
        {
            this.yandexTranslate = yandexTranslate;

            DefaultLanguage();
        }

        public void DefaultLanguage()
        {
            nameRequestUniversity = "Запрос по университетам";
            nameRequestRating = "Запрос по рейтингу";

            university = "Выберите университет:";
            ratingAverage = "Средний рейтинг не менее:";
            selectedLanguage = "Выберите язык интерфейса:";

            buttonNameRequest = "Получить список студентов";
            buttonSavePdf = "Сохранить в PDF";
            buttonSaveExcel = "Сохранить в Excel";
        }

        public void SetLanguage(string lang)
        {
            string language;
            try
            {
                language = Utils.getLang(lang);
            }
            catch (Utils.LangExeption e)
            {

            }
            finally
            {
                language = "ru-en";
            }
            
            nameRequestUniversity = yandexTranslate.Translate(nameRequestUniversity, language);
            nameRequestRating = yandexTranslate.Translate(nameRequestRating, language);

            university = yandexTranslate.Translate(university, language);
            ratingAverage = yandexTranslate.Translate(ratingAverage, language);

            buttonNameRequest = yandexTranslate.Translate(buttonNameRequest, language);
            buttonSavePdf = yandexTranslate.Translate(buttonSavePdf, language);
            buttonSaveExcel = yandexTranslate.Translate(buttonSaveExcel, language);
        }
    }
}
