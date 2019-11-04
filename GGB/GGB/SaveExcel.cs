using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;

namespace GGB
{
    public class SaveExcel 
    {
        /*private Excel.Application application;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;


        public SaveExcel()
        {
            application = new Excel.Application();
            application.Visible = false;
            application.ScreenUpdating = false;
        }

        public void Save(string path, string title, List<string> titleColumn, List<string> data)
        {
            try
            {
                if (path != null && title != null && titleColumn.Count != 0 && data.Count != 0)
                {
                    workbook = (Excel.Workbook)(application.Workbooks.Add());
                    worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                    int startColumn = 1 ;

                    int row = 2;
                    int column = 1;

                    //TODO: выделить цветом имя столбцов, нарисовать линии таблицы, изменить шрифт                 

                    Excel.Range range = (Excel.Range)worksheet.get_Range("B1", "E1").Cells;
                    range.Merge();
                    worksheet.Cells[1, 2] = title;
                    

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
            }
            catch
            {
                MessageBox.Show("Нет всех данных");
            }
            finally
            {
                Close();
            }
        }


        public void Close()
        {
            //TODO: закрыть через процессы

            workbook.Close();
            application.Quit();
        }
        */
    }
}
