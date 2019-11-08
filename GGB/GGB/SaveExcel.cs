using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GGB
{
    public class SaveExcel: ISaveExcel 
    {
        private Excel.Application application;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;

        private ErrorListener listener;


        public void Save(string path, string title, List<string> titleColumn, List<string> data)
        {
            try
            {
                if (path != null && title != null && titleColumn.Count != 0 && data.Count != 0)
                {
                    if (path != "" && title != "")
                    {

                        SetProperty();

                        //TODO: выделить цветом имя столбцов, нарисовать линии таблицы, изменить шрифт                 
                        Excel.Range range = (Excel.Range)worksheet.get_Range("B1", "E1").Cells;
                        range.Merge();
                        worksheet.Cells[1, 2] = title;

                        int startColumn = 1;
                        int row = 2;
                        int column = 1;

                        for (int i = 0; i < titleColumn.Count; i++)
                        {
                            worksheet.Cells[row, column] = titleColumn[i];
                            column++;
                        }
                        for (int i = 0; i < data.Count; i++)
                        {
                            column = startColumn;
                            for (int j = 0; j < titleColumn.Count; j++)
                            {
                                worksheet.Cells[row, column] = data[i];
                                column++;
                            }
                            row++;
                        }
                        workbook.SaveAs(path);
                    }
                    else
                    {
                        if (listener != null)
                            listener.OnError("Пустой путь для сохранения файла и (или) пустой текст заголовка для таблицы");
                    }
                }
                else
                {
                    if (listener != null)
                        listener.OnError("Нет данных для сохранения и(или) не выбран путь для сохранения");
                }
            }
            finally
            {
                Close();
            }
        }

        private void SetProperty()
        {
            application = new Excel.Application();
            application.Visible = false;
            application.ScreenUpdating = false;

            workbook = (Excel.Workbook)(application.Workbooks.Add());
            worksheet = (Excel.Worksheet)workbook.ActiveSheet;
        }

      

        public void Close()
        {
            //TODO: закрыть через процессы
            workbook.Close();
            application.Quit();
        }

        public void setErrorListener(ErrorListener listener)
        {
            this.listener = listener;
        }


    }
}
