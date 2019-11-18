using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public class Constant
    {
        public static string formatPdf = "pdf";
        public static string formatExcel = "xls";

        public static string onSuccessSaveMessage = "Успешно сохранено";
        public static string onSuccessRequestMessage = "Запрос успешно выполнен";

        public static string filterSavePdf = "Text files(*.pdf)|*.pdf";
        public static string filterSaveExcel = "Excel (*.xlsx)|*.xlsx";

        public static string isExcelExist = "EXCEL";

        public static string onErrorExcelEmptyData = "Нет данных для сохранения и(или) не выбран путь для сохранения";
        public static string onErrorExcelEmptyPath = "Пустой путь для сохранения файла и(или) пустой текст заголовка для таблицы";

        public static string onErrorSetLanguage = "Не выбран язык для перевода";

        public const string russian = "Русский";
        public const string english = "Английский";
        public const string korean = "Корейский";

        


    }
}
