using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace GGB
{
    public class YandexTranslate : IYandexTranslate
    {
        public static string key = "trnsl.1.1.20191112T055406Z.915c1f20ea7a5b48.5c63753c3c7d537691187b1288e7d541747d23b8";
        public string Translate(string text, string language)
        {
            if (text.Length > 0)
            {
                WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                    + "key=" + key
                    + "&text=" + text
                    + "&lang=" + language
                    + "&format=plain");


                //ОШИБКА ПОЛУЧЕНИЯ ОТВЕТА
                WebResponse response = request.GetResponse();
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;

                    if ((line = stream.ReadLine()) != null)
                    {
                        Translation translation = JsonConvert.DeserializeObject<Translation>(line);

                        text = "";

                        foreach (string str in translation.text)
                        {
                            text += str;
                        }
                    }
                }

                return text;
            }
            else
                return "";
        }     
    }

    public class Translation
    {
        public string code { get; set; }
        public string lang { get; set; }
        public string [] text { get; set; }
    }
}
