using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Searching
    {
        static public void SearchByPhoneNumber(Dictionary<string, List<string>> phonebok)
        {
            Console.WriteLine("Start enter to phone number");
            string SearchingNum = Console.ReadLine();
            char[] SearchingNumChar = SearchingNum.ToCharArray();
            int CountOfSearchingNumch = SearchingNumChar.Length;
            int CountOfCoincidence = 0;
            foreach (KeyValuePair<string, List<string>> Contact in phonebok)
            {
                for (int i = 0; i < Contact.Value.Count; i++)
                {
                    int Coincidences = 0;
                    char[] ContactValueChar = Contact.Value[i].ToCharArray();
                    for (int j = 0; j < SearchingNumChar.Length; j++)
                    {
                        for (int k = 0; k < CountOfSearchingNumch - 1; k++)
                        {
                            if (SearchingNumChar[j] == ContactValueChar[k])
                                Coincidences++;
                        }
                    }
                    if (CountOfSearchingNumch == Coincidences)
                    {
                        Console.WriteLine(Contact.Key + " - " + "+380" + Contact.Value[i]);
                        CountOfCoincidence++;
                    }
                }
            }
            if (CountOfCoincidence == 0)
                Console.WriteLine("Contact is not found");
        }
    }
}
