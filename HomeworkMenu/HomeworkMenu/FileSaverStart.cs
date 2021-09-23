using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class FileSaverMenu
    {
        public static void StartFileSavingProgram(FileSaver filesaver)
        {
            Link:
            Console.WriteLine("Введите текст, который вы хотите сохранить в файл");
            string usertext = Console.ReadLine();
            Console.WriteLine("Введите формат файла в котором вы хотите сохранить файл : \n" +
                "1-txt\n" +
                "2-csv\n" +
                "3-pdf\n");
            int fileformat = int.Parse(Console.ReadLine());
            switch (fileformat)
            {
                case 1:
                    filesaver.SaveAsTxt(usertext);
                    break;
                case 2:
                    filesaver.SaveAsCsv(usertext);
                    break;
                case 3:
                    var valid = FileSaver.IsValidateText(usertext);
                    if (valid)
                    {
                        filesaver.SaveAsPdf(usertext);
                    }
                    else
                    {
                        Console.Clear();
                        goto Link;
                    }

                    break;
            }
        }


    }
}
