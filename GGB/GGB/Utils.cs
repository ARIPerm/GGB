using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Utils
    {
        public const string PERM = "Пермь";
        public const string MOSCOW = "Москва";

        public static CityType GetCityTypeByName(string name)
        {
            switch (name)
            {
                case PERM:
                    return CityType.Perm;
                case MOSCOW:
                    return CityType.Moscow;
                default:
                    throw new CityException("");              
            }
        }

        public static string getLang(string lang, string currentLang)
        {
            string current = "";
            switch (currentLang)
            {
                case "Английский":
                    current = "en";
                    break;
                case "Русский":
                    current = "ru";
                    break;
                case "Корейский":
                    current = "ko";
                    break;
                default:
                    break;
            }

            switch (lang)
            {
                case "Английский":
                    return current +"-en";
                case "Русский":
                    return current + "-ru";
                case "Корейский":
                    return current + "-ko";
                default: throw new LangExeption(Constant.onErrorSetLanguage);
            }
        }

        public class LangExeption : Exception
        {
            private string message;
            public LangExeption(string message) : base(message)
            {
            }
        }

        public class CityException: Exception
        {
            public CityException(string message): base (message)
            {

            }
        }
    }
}
