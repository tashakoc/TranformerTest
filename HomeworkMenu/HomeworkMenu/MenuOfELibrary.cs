using Library;
using System;

namespace MyLibrary
{
   public class Program
    {
        public static void StartLib()
        {
            CatalogOfBook.InitialFillingOfThLibrary();
            LibraryAdmistrator.Initialize();
            
            bool isbacktomenu = true;
            while (isbacktomenu)
            {
                Console.WriteLine("Выберите действие : \n" +
               "Добавить книгу в каталог -- 1\n" +
               "Удалить книгу из каталога--2\n" +
               "Вывести содержимое каталога по алфавиту--3\n" +
               "Вывести список  книг определенного автора --4\n" +
               "Найти книгу--5\n" +
               "Взять книгу почитать--6\n" +
               "Вернуть книгу--7");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        CatalogOfBook.AddNewBook();
                        break;
                    case 2:
                        CatalogOfBook.RemoveBook();
                        break;
                    case 3:
                        CatalogOfBook.SortBooks();
                        break;
                    case 4:
                        CatalogOfBook.ShowAllBooksOFAuthor();
                        break;
                    case 5:
                        CatalogOfBook.Findbook();
                        break;
                    case 6:
                        LibraryAdmistrator.GiveBookToaReader();
                        break;
                    case 7:
                        LibraryAdmistrator.ReturnOfTheABook();
                        break;
                }
                Console.WriteLine("Вернуться в главное меню--1\nВыйти из библиотеки--2");
                int choisemenu = int.Parse(Console.ReadLine());
                if (choisemenu == 1)
                    isbacktomenu = true;
                else
                {
                    isbacktomenu = false;
                    Console.WriteLine("До свидания!!!");
                    break;
                }

            }
        }
    }
}
