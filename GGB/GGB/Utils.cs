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
                    return "ru-en";
                case "Русский":
                    return "en-ru";
                default: throw new LangExeption(); 
            }
        }

        public class LangExeption : Exception
        {

        }


    }
}
