using CsvHelper;
using CsvHelper.Configuration;
using Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{  public struct stoplendingbooks
    {
        public string readername;
        public DateTime till;
        public stoplendingbooks(string r,DateTime t) { readername = r; till = t; }
    }
     public static class LibraryAdmistrator
    {
        public static List<BookBorrow> listofborrowbooks = new List<BookBorrow>();
        public static List<stoplendingbooks> debtlist = new List<stoplendingbooks>();
        public static Dictionary<string, List<Book>> magazineofreaders = new Dictionary<string, List<Book>>();
        static public void GiveBookToaReader()
        {
            List<Book> books = new List<Book>();
            Book newbook = new Book();
            Console.WriteLine("Укажите ваше имя и фамилию");
            BookBorrow borrow = new BookBorrow();
            borrow.readername = Console.ReadLine();
            if (debtlist.Exists(d=>d.readername==borrow.readername && d.till>DateTime.Now))
            {
                Console.WriteLine("Вы не вернули книгу во время!Выдача книг приостановлена");
                return;
            }
            borrow.book = CatalogOfBook.Findbook();
            if(borrow.book == null)
            {
                Console.WriteLine("Книга не найдена!");
                return;
            }
            for (int i = 0; i < listofborrowbooks.Count; i++)
            {
                if(listofborrowbooks[i].book.nameofbook == borrow.book.nameofbook)
                {
                    Console.WriteLine("Книга уже взята другим читателем");
                    return;
                }
            }
            Console.WriteLine("На сколько дней вы берете книгу?");
            borrow.book.returndays = int.Parse(Console.ReadLine());
            borrow.borrowdate = DateTime.Now;
            Save(borrow);
        }
        static public void Save(BookBorrow borrow)
        {
            using (StreamWriter streamWriter = new StreamWriter(BookBorrow.path, true, System.Text.Encoding.UTF8))
            {
                using (CsvWriter csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.CurrentCulture))
                {
                    // указываем разделитель, который будет использоваться в файле

                    var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";" };
                    // записываем данные в csv файл
                    //csvWriter.WriteField(borrow.readername);
                    //csvWriter.WriteField(borrow.borrowdate);
                    //csvWriter.WriteField(borrow.book.nameofbook);
                    csvWriter.WriteRecord(borrow);
                    csvWriter.NextRecord();
                }
            }
        }
        static public void SaveAll(List<BookBorrow> listofborrowbooks)
        {
            using (StreamWriter streamWriter = new StreamWriter(BookBorrow.path, false, System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";", HasHeaderRecord = false };
                using (CsvWriter csvWriter = new CsvWriter(streamWriter, config))
                {
                    // указываем разделитель, который будет использоваться в файле
                    csvWriter.WriteRecords(listofborrowbooks);
                }
            }
        }
        static public void ReadAFile()
        {
            string[] test = File.ReadAllLines(BookBorrow.path);
            using (StreamReader streamReader = new StreamReader(BookBorrow.path, System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";",HasHeaderRecord = false };
                using (CsvReader csvReader = new CsvReader(streamReader, config))
                {
                    listofborrowbooks = csvReader.GetRecords<BookBorrow>().ToList();
                }
            }
        }


        static public void ReturnOfTheABook()
        {
            Console.WriteLine("Укажите ваше имя и фамилию");
            string reader = Console.ReadLine();
            Console.WriteLine("Укажите название книги");
            string nameofbook = Console.ReadLine();
            int c = listofborrowbooks.RemoveAll(bb => bb.readername == reader && bb.book.nameofbook == nameofbook);
            if (c > 0)
            {
                Console.WriteLine("Вы вернули книгу в библиотеку!");
                SaveAll(listofborrowbooks);
            }
            else
                Console.WriteLine("Эта книга не являеться собственностью библиотеки");
            


        }
        internal static void Initialize()
        {
            ReadAFile();
            AutoReturnBooks();
            SaveAll(listofborrowbooks);
        }

        private static void AutoReturnBooks()
        {
            List<BookBorrow> bookBorrows = listofborrowbooks.FindAll(bb => bb.borrowdate.AddDays(bb.book.returndays) <= DateTime.Now);
            foreach (var item in bookBorrows)
            {
                debtlist.Add(new stoplendingbooks(item.readername,DateTime.Now.AddMinutes(1)));
                listofborrowbooks.Remove(item);
            }
        }
    }

        
    }
