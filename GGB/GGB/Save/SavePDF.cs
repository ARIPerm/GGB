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
    public class SavePDF : ISavePDF
    {
        private BaseFont baseFont;
        private Font font;
        private PdfPTable table;

        private Document document;

        private ErrorListener listener;


        public void Save(string path, List<string> title, List<string> data)
        {

            if (path != null && title != null && data != null)
            {
                SetProperty();

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
                Close();
            }
            else
            {
                if (listener != null)
                    listener.OnError("Нет данных для сохранения и(или) не выбран путь для сохранения");
                
            }

        }

        public void Close()
        {
            document.Close();
        }


        public void setErrorListener(ErrorListener listener)
        {
            this.listener = listener;
        }

        private void SetProperty()
        {
            document = new Document();
            baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);
        }
    }
}
