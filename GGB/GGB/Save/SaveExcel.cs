using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GGB
{
    public class SaveExcel : ISaveExcel
    {
        private Excel.Application application;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;

        private ErrorListener listener;


        public void Save(string path, string title, List<string> titleColumn, List<string> data)
        {
            if (path != null && title != null && titleColumn != null && data != null)
            {
                if (path != "" && title != "")
                {
                    SetProperty(path);

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

                    Close();
                }
                else
                {
                    if (listener != null)
                        listener.OnError(Constant.onErrorExcelEmptyPath);
                }
            }
            else
            {
                if (listener != null)
                    listener.OnError(Constant.onErrorExcelEmptyData);
            }


        }

        private void SetProperty(string path)
        {
            application = new Excel.Application();
            application.Visible = false;
            application.ScreenUpdating = false;

            workbook = application.Workbooks.Add(1);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
        }



        private void Close()
        {
            Process[] procList = Process.GetProcesses();
            foreach (Process p in procList)
            {
                if (p.ProcessName.ToString().Trim().ToUpper() == "EXCEL")
                {
                    p.Kill();
                }
            }
        }

        public void setErrorListener(ErrorListener listener)
        {
            this.listener = listener;
        }

        public bool ExistenceExcel()
        {
            Type officetype = Type.GetTypeFromProgID("Excel.Application");
            return officetype == null;            
        }
    }
}
