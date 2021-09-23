using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class Valuta
    {
        public static Dictionary<string, double> rate = new Dictionary<string, double>();
        static public void GBPRate()
        {
            rate.Add("RUB", 11.25);
            rate.Add("USD", 1.38);
            rate.Add("EUR", 1.17);
            rate.Add("UAH", 36.74);
        }

        static public void USDRate()
        {
            rate.Add("RUB", 73.30);
            rate.Add("GBP", 0.73);
            rate.Add("EUR", 0.85);
            rate.Add("UAH", 26.68);
        }
        static public void UAHRate()
        {
            rate.Add("RUB", 2.74);
            rate.Add("USD", 0.037);
            rate.Add("EUR", 0.032);
            rate.Add("GBP", 0.027);
        }
        static public void RUBRate()
        {
            rate.Add("GBP", 0.0099);
            rate.Add("USD", 0.014);
            rate.Add("EUR", 0.36);
            rate.Add("UAH", 36.74);
        }
        static public void EURRate()
        {
            rate.Add("GBP", 0.86);
            rate.Add("USD", 1.18);
            rate.Add("RUB", 86.55);
            rate.Add("UAH", 31.53);
        }
    }
}
