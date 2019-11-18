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
            switch(name)
            {
                case PERM:
                    return CityType.Perm;
                case MOSCOW:
                    return CityType.Moscow;
                default: throw new Exception();

            }
        }



        public static string getLang(string lang)
        {

            switch (lang)
            {
                case "Английский":
                    return "en";
                case "Русский":
                    return "ru";
                case "Корейский":
                    return "ko";
                default: throw new LangExeption(Constant.onErrorSetLanguage); 
            }
        }

        public class LangExeption : Exception
        {
            public LangExeption(string message) : base(message)
            { }
        }


    }
}
