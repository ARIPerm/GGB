using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace GGB
{
    //Maria
    public class SavePDF : ISavePDF
    {
        private BaseFont baseFont;
        private Font font;
        private PdfPTable table;

        private Document document;


        public SavePDF()
        {
            document = new Document();
            baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);

            
        }


        public void Save(string path, List<string> title, List<string> data)
        {
            try
            {
                if (path != null && title.Count != 0 && data.Count != 0)
                {

                    PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

                    document.Open();
                    document.NewPage();

                    //TODO: добавить заголовок таблицы, изменить шрифт 

                    table = new PdfPTable(title.Count);
                    PdfPCell cell;
                    for (int i = 0; i < title.Count; i++)
                    {
                        cell = new PdfPCell(new Phrase(title[i], font));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    for (int i = 0; i < data.Count; i++)
                    {
                        cell = new PdfPCell(new Phrase(data[i], font));
                        table.AddCell(cell);
                    }

                    document.Add(table);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("Нет данных для сохранения");
                //через события
                
            }
            finally
            {
                Close();
            }
        
        }

        public void Close()
        {
            document.Close();
        }
        
    }
}
