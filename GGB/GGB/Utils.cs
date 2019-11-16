using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Utils
    {


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
                default: throw new LangExeption("Не выбран язык для перевода"); 
            }
        }

        public class LangExeption : Exception
        {
            public LangExeption(string message) : base(message)
            { }
        }


    }
}
