using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Admin
    {
        public static void setadmin(Dictionary<string, string> persons)
        {
            string logAdm = "Admin";
            string passAdm = "Admin";
            Console.WriteLine("Админ цэ ты? ввэды логина");
            string loginAdm = Console.ReadLine();
            Console.WriteLine("Админ цэ ты? ввэды пароля");
            string passwordAdm = Console.ReadLine();

            if (loginAdm == logAdm && passwordAdm == passAdm) //(persons.ContainsKey(loginAdm) && persons.ContainsValue(passwordAdm))
            {
                Console.WriteLine("Вы вошли как админ!");
                foreach (KeyValuePair<string, string> keyValue in persons)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
                char choise1 = ' ';
                do
                {
                    if (choise1 == 3)
                        break;

                    Console.WriteLine("Выберите действие: удалить аккаунт зарег пользователя - 1, изменить акк зарег пользователя - 2");
                    char choise = char.Parse(Console.ReadLine());
                    if (choise == '1')
                    {
                        //char choise1 = ' ';
                        do
                        {
                            Console.WriteLine("Какой акк вы хотите удалить? (введите логин аккаунта): ");
                            string user = Console.ReadLine();
                            persons.Remove(user);
                            Console.WriteLine("Удален! Удалить еще кого то?? да - 1, перейти в меню админа - 2, перейти в главное меню - 3");
                            choise1 = char.Parse(Console.ReadLine());
                        if (choise1 == 3)
                            break;
                        }
                        while (choise1 == '1');
                    }
                    if (choise == '2')
                    {
                        Console.WriteLine("Какой акк вы хотите изменить? (введи логин)");
                        string user2 = Console.ReadLine();
                        Console.WriteLine("Введи пароль: ");
                        string user3 = Console.ReadLine();
                        Console.WriteLine("Вы хотите изменить логин - 1 или пароль - 2?");
                        string otvet = Console.ReadLine();
                        if (otvet == "1")
                        {
                            
                            persons.Remove(user2);
                            Console.WriteLine("Введите новый логин: ");
                            string newLogin = Console.ReadLine();
                            persons.Add(newLogin, user3);

                        }
                        if (otvet == "2")
                        {
                            Console.WriteLine("Введите новый пароль: ");
                            persons[user3] = Console.ReadLine();
                        }
                    }

                }
                while (choise1 == '2');

                    foreach (KeyValuePair<string, string> keyValue in persons)
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                

            }

        }
    }
}
