using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
     public class Customer
    {
        public string nameofcustomer { get; set; }
        public int money { get; set; }
        public Customer(string n) { nameofcustomer = n; }
        public static string pathcustomer = "D:\\listofcustomers.csv";
        public static List<Customer> listofallcustomer = new List<Customer>();
        public Customer(string n,int m) { nameofcustomer = n; money = m; }
        public Customer() { }
        public static Customer RegistrationOfCustomer()
        {
            Customer newcustomer = new Customer();
            Console.WriteLine("Укажите ваше имя");
            newcustomer.nameofcustomer = Console.ReadLine();
            newcustomer.money = 50;
            listofallcustomer.Add(newcustomer);
            SaveFile(newcustomer);
            return newcustomer;
        }
        static public void BuyProduct(Customer customer)
        {
            Console.WriteLine("Укажите товар который вы хотите преобрести");
            string choiseofproduct = Console.ReadLine();
            bool isexist = false;
            foreach (var product in Product.listofallproducts)
            {
                if (product.nameofproduct == choiseofproduct)
                {
                    isexist = true;
                    if (product.number <= 1)
                    {
                        Console.WriteLine("Данный товар не доступен для продажи");
                    }
                    else
                    {
                        Console.WriteLine("Укажите сколько едениц товара вы хотите приобрести: ");
                        int countofproduct = int.Parse(Console.ReadLine());
                        int totalamount = product.price * countofproduct;
                        if (totalamount > customer.money)
                        {
                            Console.WriteLine($"У вас не достаточно денег для покупки. Вам не хватает {totalamount - customer.money}$");
                        }
                        else
                        {
                            customer.money -= totalamount;
                            product.number -= countofproduct;
                            SaveFile(customer);
                            Manager.SaveAsFile(Product.listofallproducts);
                        }
                    }
                }
            }
            if(!isexist)
                Console.WriteLine("Данного товара нет в нашем магазине");

        }
        static public void WatchListOfProduct()
        {
            foreach (var item in Product.listofallproducts)
            {
                Console.WriteLine($"Название товара : {item.nameofproduct}\tЦена: {item.price}\tКоличество товара в наличии:{item.number}");
            }

        }
        static public void SaveFile(Customer newcustomer)
        {
            using (StreamWriter streamWriter = new StreamWriter(pathcustomer, false, System.Text.Encoding.UTF8))
            {
                using (CsvWriter csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.CurrentCulture))
                {

                    var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";" };
                    // записываем данные в csv файл
                    csvWriter.WriteRecord(newcustomer);
                    csvWriter.Flush();

                }
            }
        }
        static public void ReadAFile()
        {
            string[] test = File.ReadAllLines(pathcustomer);
            using (StreamReader streamReader = new StreamReader(pathcustomer, System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";", HasHeaderRecord = false };
                using (CsvReader csvReader = new CsvReader(streamReader, config))
                {
                    List<Customer> listofallcustomer = csvReader.GetRecords<Customer>().ToList();
                }
            }
        }
    }
}
