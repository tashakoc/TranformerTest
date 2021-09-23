using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class ShowAll
    {
        static public void ShowAllContacts(Dictionary<string, List<string>> phonebok)
        {
            foreach (KeyValuePair<string, List<string>> Contact in phonebok)
            {
                Console.WriteLine(Contact.Key + " : ");
                for (int i = 0; i < Contact.Value.Count; i++)
                {
                    Console.WriteLine("+380" + Contact.Value[i]);
                }
            }
        }
    }
}
