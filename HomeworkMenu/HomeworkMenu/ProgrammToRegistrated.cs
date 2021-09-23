using Homework_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class ProgrammToRegistrated
    {
        static public void MakeDessision()
        {
            char cont = '1';
            char stop = '2';
            char choise = ' ';
            Dictionary<string, string> persons = new Dictionary<string, string>();
            do
            {
                Console.WriteLine("Выберете действие:  Регистрация - 1, Авторизация -2, Зайти как администратор - 0");
                int setmove = int.Parse(Console.ReadLine());
                switch (setmove)
                {
                    case 1:
                        Registrarion.Registration(persons);
                        break;
                    case 2:
                        autorization.Autorization(persons);
                        break;
                    case 0:
                        Admin.setadmin(persons);
                        break;
                    default:
                        break;
                }
                //foreach (KeyValuePair<string, string> keyValue in persons)
                //{
                //    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                //}
                Console.WriteLine("Продолжить - 1, Закрыть - 2 ");
                choise = char.Parse(Console.ReadLine());
            }
            while (choise == cont);

            foreach (KeyValuePair<string, string> keyValue in persons)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
}
