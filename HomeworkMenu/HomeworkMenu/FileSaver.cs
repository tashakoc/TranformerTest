using System;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using iTextSharp.text.pdf;
using iTextSharp.text;
using PdfSharp.Pdf.IO;

namespace HomeworkMenu
{ 
    internal  interface SaveAs
    {
        public  void SaveAsTxt(string usertext);
        public  void SaveAsCsv(string usertext);
        public  void SaveAsPdf(string usertext);
    }
    public  class FileSaver:SaveAs
    {
        public static string filesaveastxt = @"D:\hwfile.txt";
        string pathCsvFile = "D:\\programmingLanguages.csv";
        public static string filesaveaspdf = @"D:\hwfile.pdf";

        public  void SaveAsTxt(string usertext)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filesaveastxt, false))
                {
                    sw.WriteLine(usertext);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public  void SaveAsCsv(string usertext)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(pathCsvFile, false, System.Text.Encoding.UTF8))
                {
                    var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture);
                    csv.WriteRecords(usertext); // where values implements IEnumerable
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void SaveAsPdf(string usertext)
        {
            //var document = new iTextSharp.text.Document(PageSize.A4, 20, 20, 30, 20);

            //string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALNBI.TTF");
            //var bfCourier = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
            //var courier = new Font(bfCourier, 12, Font.ITALIC, BaseColor.RED);


            //using (var writer = PdfWriter.GetInstance(document, new FileStream("c:\\Test11.pdf", FileMode.Create)))
            //{
            //    document.Open();
            //    document.NewPage();
            //    document.Add(new Paragraph(usertext, courier));
            //    document.Close();
            //    writer.Close();
            //}
            try
            {
                //Работает только для английских букв
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("c:\\Test11.pdf", FileMode.Create));
                doc.Open();//Open Document to write
                Phrase pharse = new Phrase(usertext);
                doc.Add(pharse);
                doc.Close(); //Close document
                Console.WriteLine("Запись выполнена");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
        public static bool IsValidateText(string text)
        {
            string[] array = text.Split(" ");
            var bug = "йцукенгшщзхфывапролдячсмить";
            bool res = true; // для того,чтобы понять есть ли у нас слова сод запрет символы
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < bug.Length; k++)
                {
                    if (array[i].Contains(bug[k]))
                    {
                        Console.WriteLine("нашел");
                        res = false;
                        break;
                    }
                }
            }
            return res;
        }
    }
}
