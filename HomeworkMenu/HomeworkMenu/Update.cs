using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Update
    {
        static public void UpdateContact(Dictionary<string, List<string>> phonebok)
        {
            foreach (KeyValuePair<string, List<string>> Contact in phonebok)
            {
                for (int i = 0; i < Contact.Value.Count; i++)
                {
                    Console.WriteLine(Contact.Key + " - " + "+380" + Contact.Value[i]);
                }
            }
            Console.WriteLine("Enter name of contact you wanna update");
            string ContactToUpDate = Console.ReadLine();
            if (phonebok.ContainsKey(ContactToUpDate))
            {
                Console.WriteLine("Enter serial number of number you wanna update");
                int SerialNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new number: ");
                string NewNumber = Console.ReadLine();
                if (Validation.IsValidated(NewNumber))
                {
                    phonebok[ContactToUpDate][SerialNumber] = NewNumber;
                    Console.WriteLine("Contact is updated");
                }
                else
                    Console.WriteLine("Wrong number input format!");
            }
            else
                Console.WriteLine("Contact is not found");
        }
    }
}
