using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class BookBorrow
    {
       public string readername { get; set; }
        public DateTime borrowdate { get; set; }
        public Book book { get; set; }
        public static string path= "D:\\borrowlist.csv";
    }
}
