using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Delete
    {
        public static void DeleteContact(Dictionary<string, List<string>> phonebok)
        {
            foreach (KeyValuePair<string, List<string>> Contact in phonebok)
            {
                for (int i = 0; i < Contact.Value.Count; i++)
                {
                    Console.WriteLine(Contact.Key + " - " + "+380" + Contact.Value[i]);
                }
            }
            Console.WriteLine("Enter name of contact you wanna delete");
            string ContactToDelete = Console.ReadLine();
            if (phonebok.ContainsKey(ContactToDelete))
            {
                phonebok.Remove(ContactToDelete);
                Console.WriteLine("Contact is deleted");
            }
            else
                Console.WriteLine("Contact is not found");
        }
    }
}
