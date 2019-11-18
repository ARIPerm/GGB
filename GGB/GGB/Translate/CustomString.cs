using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GGB
{
    public class CustomString : ICustomString
    {
        public string nameRequestUniversity { get; set;  }
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
            string language = null;
            try
            {
                language = Utils.getLang(lang);
            }
            catch (Utils.LangExeption e)
            {
                //сделать через вью
                Console.WriteLine($"Ошибка: {e.Message}");
                language = "ru-en";
            }

            nameRequestUniversity = yandexTranslate.Translate(nameRequestUniversity, language);
            nameRequestRating = yandexTranslate.Translate(nameRequestRating, language);

            university = yandexTranslate.Translate(university, language);
            ratingAverage = yandexTranslate.Translate(ratingAverage, language);
            selectedLanguage = yandexTranslate.Translate(selectedLanguage, language);

            buttonNameRequest = yandexTranslate.Translate(buttonNameRequest, language);
            buttonSavePdf = yandexTranslate.Translate(buttonSavePdf, language);
            buttonSaveExcel = yandexTranslate.Translate(buttonSaveExcel, language);

            Constant.onSuccessRequestMessage = yandexTranslate.Translate(Constant.onSuccessRequestMessage, language);
            Constant.onSuccessSaveMessage = yandexTranslate.Translate(Constant.onSuccessSaveMessage, language);

        }


        public void SettingLaunguage(string lang)
        {
            string language = null;
            try
            {
                language = Utils.getLang(lang);
            }
            catch (Utils.LangExeption e)
            {
                //сделать через вью
                Console.WriteLine($"Ошибка: {e.Message}");
                language = "ru-en";
            }


            Translator translate1 = new Translator(language, nameRequestUniversity, yandexTranslate);

            Thread thread = new Thread(new ThreadStart(translate1.SetLanguageWithTread));
            thread.Start();

            
            if (thread.ThreadState == ThreadState.Stopped)
                nameRequestUniversity = translate1.text + "gfagfsag";


        }



    }

    public class Translator
    {
        public string text;
        public string lang;
        public IYandexTranslate yandexTranslate;

        public Translator(string lang, string text, IYandexTranslate yandex)
        {
            this.lang = lang;
            this.text = text;
            this.yandexTranslate = yandex;
        }

        public void SetLanguageWithTread()
        {
            text = yandexTranslate.Translate(text, lang);
        }
    }

}
