using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Validation
    {
        static public bool IsValidated(string number)
        {
            char[] CharNumber = number.ToCharArray();
            for (int i = 0; i < CharNumber.Length; i++)
            {
                if (Char.IsDigit(CharNumber[i]))
                    return true;
            }
            return false;
        }
    }
}
