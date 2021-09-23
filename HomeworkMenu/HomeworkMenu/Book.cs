using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string nameofbook { get; set; }
        public string author { get; set; }
        public string year { get; set; }
        public int returndays { get; set; }
        public static string pathCsvFile = "D:\\fulllistofbook.csv";
        public bool issaved = false;
        public Book(string n, string a, string y, int w = -1) { nameofbook = n; author = a; year = y; returndays = w; }
        public Book() {}

    }
}
