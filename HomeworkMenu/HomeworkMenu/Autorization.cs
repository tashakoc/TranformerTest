using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class autorization
    {
      public static void Autorization(Dictionary<string, string> persons)
        {
            Console.WriteLine("Enter login");
            var login1 = Console.ReadLine();
            Console.WriteLine("Enter password");
            var password1 = Console.ReadLine();

            if (persons.ContainsKey(login1) && persons.ContainsValue(password1))
            {
                Console.WriteLine("Autorization was succesfull");
                Console.WriteLine("Желаете выйти - 1");
                char exit = char.Parse(Console.ReadLine());
                if (exit == '1')
                    Console.WriteLine("Вы вышли с аккаунта");
            }
            else
                Console.WriteLine("user wasn't found");

        }
        



    }
}
