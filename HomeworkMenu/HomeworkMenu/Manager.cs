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
    class Manager
    {
        public static void AddFirstGroupOfProduct()
        {
            ReadAFile();
            if(Product.listofallproducts.Count == 0)
            {
                Product product1 = new Product("Яблоко", 5, 10);
                Product.listofallproducts.Add(product1);
                Product product2 = new Product("Груша", 7, 10);
                Product.listofallproducts.Add(product2);
                Product product3 = new Product("Огурец", 8, 10);
                Product.listofallproducts.Add(product3);
                Product product4 = new Product("Баклажан", 10, 10);
                Product.listofallproducts.Add(product4);
                Product product5 = new Product("Помидор", 4, 10);
                Product.listofallproducts.Add(product5);
                Product product6 = new Product("Перец", 7, 10);
                Product.listofallproducts.Add(product6);
                Product product7 = new Product("Хлеб", 2, 10);
                Product.listofallproducts.Add(product7);
                Product product8 = new Product("Сахар", 7, 10);
                Product.listofallproducts.Add(product8);
                Product product9 = new Product("Гречка", 2, 10);
                Product.listofallproducts.Add(product9);
                Product product10 = new Product("Мука", 8, 10);
                Product.listofallproducts.Add(product10);
                SaveAsFile(Product.listofallproducts);
            }
        }
        public static void AddProduct()
        {
            Console.WriteLine("Укажите название товара, который вы хотите добавить: ");
            string newproduct = Console.ReadLine();
            Product product = Product.listofallproducts.Find(item => item.nameofproduct== newproduct);
            if (product == null)
            {
                Product product1 = new Product();
                product1.nameofproduct = newproduct;
                Console.WriteLine("Укажите количество единиц товара,которое необходимо добавить");
                product1.number = int.Parse(Console.ReadLine());
                Console.WriteLine("Укажите цену одной единицы товара");
                product1.number = int.Parse(Console.ReadLine());
                Product.listofallproducts.Add(product1);
            }
            else
            {
                Console.WriteLine("Укажите количество единиц товара,которое необходимо добавить");
                product.number += int.Parse(Console.ReadLine());
            }
            SaveAsFile(Product.listofallproducts);

        }
        public static void RemoveProduct()
        {
            Console.WriteLine("Укажите товар,который вы хотите исключить из ассортимента магазина");
            string nameofproduct = Console.ReadLine();
            Product product = Product.listofallproducts.Find(item => item.nameofproduct == nameofproduct);
            if(product == null)
            {
                Console.WriteLine("Такого товара нет в ассортименте магазина");
            }
            else
            {
                Product.listofallproducts.Remove(product);
                SaveAsFile(Product.listofallproducts);
            }
        }
        static public void SaveAsFile(List<Product> listofallproducts)
        {
            using (StreamWriter streamReader = new StreamWriter(Product.pathproduct, false, System.Text.Encoding.UTF8))
            {
                using (CsvWriter csvReader = new CsvWriter(streamReader, System.Globalization.CultureInfo.CurrentCulture))
                {

                    var csv = new StringBuilder();
                    // указываем разделитель, который будет использоваться в файле
                    var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";" };
                    // записываем данные в csv файл
                    csvReader.Flush();

                    csvReader.WriteRecords(listofallproducts);

                }
            }
        }
        static public void ReadAFile()
        {
            string[] test = File.ReadAllLines("D:\\product.csv");
            using (StreamReader streamReader = new StreamReader("D:\\product.csv", System.Text.Encoding.UTF8))
            {
                var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";", HasHeaderRecord = true };
                using (CsvReader csvReader = new CsvReader(streamReader, config))
                {
                    Product.listofallproducts = csvReader.GetRecords<Product>().ToList();
                }
            }
        }
    }
}
