using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    public class Product
    {
        public string nameofproduct { get; set; }
        public int price { get; set; }
        public int number { get; set; }
        public static string pathproduct = "D:\\product.csv";
        public static List<Product> listofallproducts= new List<Product>();
        public Product(string n,int p,int num) { nameofproduct = n;price = p;number = num; }
        public Product() { }

    }
}
