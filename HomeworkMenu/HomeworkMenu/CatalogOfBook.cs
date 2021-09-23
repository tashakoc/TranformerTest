using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic.FileIO;
using MyLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Library
{
    public class CatalogOfBook
    {
        public static List<Book> fulllistofbook = new List<Book>();
        static public void InitialFillingOfThLibrary()
        {
            ReadAFile();
            if(fulllistofbook.Count == 0)
            {
                Book book1 = new Book("Доктор Живаго", "Борис Пастернак", "1958");
                fulllistofbook.Add(book1);
                Book book2 = new Book("Бойцовский клуб", "Чак Паланик", "1978");
                fulllistofbook.Add(book2);
                Book book3 = new Book("Азазель", "Борис Акунин", "1987");
                fulllistofbook.Add(book3);
                Book book4 = new Book("Особые поручения", "Борис Акунин", "1990");
                fulllistofbook.Add(book4);
                Book book5 = new Book("Женщины Лазаря", "Марина Степанова", "1989");
                fulllistofbook.Add(book5);
                SaveAsFile(fulllistofbook);
            }
            
        }
        static public void AddNewBook()
        {
            Book newbook = new Book();
            Console.WriteLine("Укажите автора книги");
            newbook.author = Console.ReadLine();
            Console.WriteLine("Укажите название книги");
            newbook.nameofbook = Console.ReadLine();
            Console.WriteLine("Укажите год издательства книги");
            newbook.year = Console.ReadLine();
            fulllistofbook.Add(newbook);
            SaveAsFile(newbook);
        }
        static public void RemoveBook()
        {      
            Console.WriteLine("Укажите название книги");
            string nameofbook = Console.ReadLine();
                foreach (var book in fulllistofbook)
                {
                    if (book.nameofbook == nameofbook)
                    {
                        fulllistofbook.Remove(book);
                        Console.WriteLine("Книга удалена");
                        break;
                    }
                }
                SaveAsFile(fulllistofbook);
        }

        static public void SortBooks()
        {
            Console.WriteLine("Отсортировать по названию книги--1\nОтсортировать по автору--2");
            int sortby = int.Parse(Console.ReadLine());
            switch (sortby)
            {
                case 1:
                        fulllistofbook.Sort(delegate (Book book1, Book book2)
                        { return book1.nameofbook.CompareTo(book2.nameofbook); });
                        foreach (var book in fulllistofbook)
                        {
                            Console.WriteLine(book.nameofbook + " " + book.author + " " + book.year + " " + book.returndays);
                        }                    
                    break;
                case 2:
                        fulllistofbook.Sort(delegate (Book book1, Book book2)
                        { return book1.author.CompareTo(book2.nameofbook); });
                        foreach (var book in fulllistofbook)
                        {
                            Console.WriteLine(book.nameofbook + " " + book.author + " " + book.year + " " + book.returndays);
                        }
                    break;
            }           
        }
        static public void ShowAllBooksOFAuthor()
        {
                Console.WriteLine("Укажите имя автора : ");
                string authorofbooks = Console.ReadLine();
                List<Book> foundBooks = fulllistofbook.FindAll(item => item.author == authorofbooks);
                foreach (Book book in foundBooks)
                    Console.WriteLine(book.nameofbook + " " + book.author + " " + book.year + " " + book.returndays);
        }
        static public Book Findbook()
        {
            Book searchingbook = new Book();
            Console.WriteLine("Укажите слово из названия книги : ");
            searchingbook.nameofbook = Console.ReadLine();
                foreach (var book in fulllistofbook)
                {
                    if (book.nameofbook.Contains(searchingbook.nameofbook))
                    {
                        Console.WriteLine(book.nameofbook + " " + book.author + " " + book.year + " " + book.returndays);

                    return book;
                    }
                }
            return null;
        }

        static public void SaveAsFile(List<Book> listofbook)
        {
            using (StreamWriter streamReader = new StreamWriter(Book.pathCsvFile, false, System.Text.Encoding.UTF8))
            {
                using (CsvWriter csvReader = new CsvWriter(streamReader, System.Globalization.CultureInfo.CurrentCulture))
                {
                    
                    var csv = new StringBuilder();
                    // указываем разделитель, который будет использоваться в файле
                    var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";" };
                    // записываем данные в csv файл
                    csvReader.Flush();

                    csvReader.WriteRecords(listofbook);

                }
            }
        }
        static public void SaveAsFile(Book book)
        {
            using (StreamWriter streamReader = new StreamWriter(Book.pathCsvFile, true, System.Text.Encoding.UTF8))
            {
                using (CsvWriter csvReader = new CsvWriter(streamReader, System.Globalization.CultureInfo.CurrentCulture))
                {
                    // указываем разделитель, который будет использоваться в файле
                    var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";" };
                    // записываем данные в csv файл
                    csvReader.WriteRecord(book);
                    csvReader.Flush();
                    book.issaved = true;

                }
            }
        }
        static public void ReadAFile()
        {
            string[] test = File.ReadAllLines("D:\\fulllistofbook.csv");
            int a = 0;
            string[] elements;
            string[] nameofbook = new string[test.Length];
            string[] author = new string[test.Length];
            string[] year = new string[test.Length];
            int[] whenreturn = new int[test.Length];
            Book sortedbook = new Book();
            for (a = 1; a < test.Length; a++)
            {
                elements = test[a].Split(';', ',');
                nameofbook[a] = elements[0];
                author[a] = elements[1];
                year[a] = elements[2];
                whenreturn[a] = int.Parse(elements[3]);
                sortedbook = new Book(nameofbook[a], author[a], year[a], whenreturn[a]);
                sortedbook.issaved = true;
                fulllistofbook.Add(sortedbook);


            }

        }
    }
}
