using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class AddContact
    {
        public static void AddContactNameAndNumber(Dictionary<string, List<string>> phonebok)
        {
            List<string> Numbers = new List<string>();
            Console.Write("Enter contact name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter phone number : ");
            string Number = Console.ReadLine();
            if (Validation.IsValidated(Number))
            {
                Numbers.Add(Number);
                string Answer;
                string Number2;
                do
                {
                    Console.WriteLine("Do you wanna add one more number to this contact(yes/no)");
                    Answer = Console.ReadLine();
                    if (Answer == "yes")
                    {
                        Console.Write("Enter phone number : ");
                        Number2 = Console.ReadLine();
                        Numbers.Add(Number2);
                    }
                    else
                        break;
                }
                while (Answer == "yes");
                phonebok.Add(Name, Numbers);
            }
            else
                Console.WriteLine("Wrong number input format!");
        }
       
    }
}
