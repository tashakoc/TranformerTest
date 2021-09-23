using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class PB
    {
        static public void StartPhonebook()
        {
            Dictionary<string, List<string>> phonebok = new Dictionary<string, List<string>>();
            string menu;
            do
            {
                Console.WriteLine("Choose an action : \nAdd contact--1\nDelete contact--2\nUpdate contact--3\nDisplay all phone numbers--4\nDisplay a specific contact--5\nЫearch by phone number--6");
                int choise = int.Parse(Console.ReadLine());


                switch (choise)
                {
                    case 1:
                        AddContact.AddContactNameAndNumber(phonebok);
                        break;
                    case 2:
                        Delete.DeleteContact(phonebok);
                        break;
                    case 3:
                        Update.UpdateContact(phonebok);
                        break;
                    case 4:
                        ShowAll.ShowAllContacts(phonebok);
                        break;
                    case 5:
                        Show1contact.PrintContactOnDisplay(phonebok);
                        break;
                    case 6:
                        Searching.SearchByPhoneNumber(phonebok);
                        break;
                }
                Console.WriteLine("Do you wanna continue?(yes/no)");
                menu = Console.ReadLine();
                Console.Clear();
            }
            while (menu == "yes");
        }
    }
}
