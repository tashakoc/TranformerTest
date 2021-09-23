using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Registrarion
    {
        public static void Registration(Dictionary<string, string> persons)
        {
            
            string login = LogValid(persons); // исп метод LogValid
            Console.WriteLine("Enter password");
            var password = Console.ReadLine(); 
            persons.Add(login, password);
     
            Console.Clear();
            Console.WriteLine("Registration was succesfull");
        }

      

       public static string LogValid(Dictionary<string, string> persons)
        {
            bool IsRussian = false; // пока false цикл не повторяется
            int couter = 0;
           string login = "";
           string validation = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮйцукенгшщзхъфывапролджэячсмитьбю+-=_)|([]{};:,.''<>?!";
            char[] words = validation.ToCharArray();
            do
            {
                IsRussian = false;
                if (couter >= 1)
                    Console.WriteLine("Такой логин уже существует или введеный логин не правильно введеный");

                Console.WriteLine("Enter your login");
                login = Console.ReadLine();
                foreach (var item in words) // каждый элемент перебирает
                {
                if (login.Contains(item)) // если содержит элемент из валидейшен,то ошибка
                  {
                    IsRussian = true; // если true цикл повторяется
                        break;
                  }
                }
                couter++;
            }
            while (IsRussian || persons.ContainsKey(login)); // проверка валидации
            return login;


              }
        }
    }
