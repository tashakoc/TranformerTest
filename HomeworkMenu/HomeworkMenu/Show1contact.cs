using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Show1contact
    {
       static public void PrintContactOnDisplay(Dictionary<string, List<string>> phonebok)
       {
            Console.WriteLine("Enter contact name you wanna see");
            string ContactName = Console.ReadLine();
            if (phonebok.ContainsKey(ContactName))
            {
                Console.WriteLine("Press 1 if you wanna see 1 phone number of thic contact and 2 if you wanna see allthis contact phone numbers");
                int UserAnswer = int.Parse(Console.ReadLine());
                switch (UserAnswer)
                {
                    case 1:
                        foreach (KeyValuePair<string, List<string>> Contact in phonebok)
                        {
                            for (int i = 0; i < Contact.Value.Count; i++)
                            {
                                Console.WriteLine(Contact.Key + " - " + "+380" + Contact.Value[i]);
                            }
                        }
                        break;
                    case 2:
                        foreach (KeyValuePair<string, List<string>> Contact in phonebok)
                        {
                            Console.WriteLine(Contact.Key + " - " +"+380"+ Contact.Value[0]);
                        }
                        break;
                }
            }
            else
                Console.WriteLine("Contact is not found");

        }
    }
}
