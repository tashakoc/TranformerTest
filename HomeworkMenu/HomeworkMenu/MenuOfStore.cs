using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class MenuOfStore
    {
        public static void Menu()
        {
            Manager.AddFirstGroupOfProduct();
            Console.WriteLine("Войти как покупатель -> 1\nВойти как менеджер -> 2 ");
            int role = int.Parse(Console.ReadLine());
            int iscontue;
            switch (role)
            {
                
                case 1:
                    Customer.ReadAFile(); 
                   Customer newcustomer =  Customer.RegistrationOfCustomer();
                    Console.Clear();
                    Link:
                    Console.WriteLine("Посмотреть список товаров -> 1\nКупить товар -> 2 ");
                    int customerchoise = int.Parse(Console.ReadLine());
                    if (customerchoise == 1)
                        Customer.WatchListOfProduct();
                    if (customerchoise == 2)
                        Customer.BuyProduct(newcustomer);
                    Console.WriteLine("Продолжить покупки  -> 1\nВыйти из магазина  -> 2");
                    iscontue = int.Parse(Console.ReadLine());
                    if (iscontue == 1)
                        goto Link;
                    break;
                case 2:
                    Link2:
                    Console.WriteLine("Добавить товар  -> 1\nУдалить товар  -> 2\nПосмотреть список товаров -> 3");
                    int manegerchoise = int.Parse(Console.ReadLine());
                    if (manegerchoise == 1)
                        Manager.AddProduct();
                    if (manegerchoise == 2)
                        Manager.RemoveProduct();
                    if (manegerchoise == 3)
                        Customer.WatchListOfProduct();
                    Console.WriteLine("Продолжить -> 1\nВыйти -> 2");
                    iscontue = int.Parse(Console.ReadLine());
                    if (iscontue == 1)
                        goto Link2;
                        break;
            }
        }
    }
}
