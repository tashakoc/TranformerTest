using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
  
    public class Converter
    { public enum valuta
        {
            UAH,
            RUB,
            GBP,
            USD,
            EUR
        }
        public static void  GetInfo()
        {
            Console.WriteLine("Укажите  валюту которую вы хотите поменять");
            valuta valuta = (valuta)Enum.Parse(typeof(valuta), Console.ReadLine());
            Console.WriteLine("Укажите  валюту которую вы хотите получить");
            string uservaluta = Console.ReadLine();
            Console.WriteLine("Укажите  сумму которую вы хотите поменять");
            int sumofuservaluta = int.Parse(Console.ReadLine());
            ConvertMoney(valuta, uservaluta, sumofuservaluta);



        }
        public static void ConvertMoney(valuta valuta,string uservaluta,int sumofuservaluta)
        {
            double newsum;
            if (valuta == valuta.UAH)
            {
                Valuta.UAHRate();
                foreach (KeyValuePair<string, double> val in Valuta.rate)
                {
                    if (val.Key == uservaluta)
                    {
                        newsum = sumofuservaluta * val.Value;
                        Console.WriteLine($"{sumofuservaluta} грн = {newsum} {val.Key}") ;
                    }
                }

            }
            if (valuta == valuta.RUB)
            {
                Valuta.RUBRate();
                foreach (KeyValuePair<string, double> val in Valuta.rate)
                {
                    if (val.Key == uservaluta)
                    {
                        newsum = sumofuservaluta * val.Value;
                        Console.WriteLine($"{sumofuservaluta} руб = {newsum} {val.Key}");
                    }
                }

            }
            if (valuta == valuta.GBP)
            {
                Valuta.GBPRate();
                foreach (KeyValuePair<string, double> val in Valuta.rate)
                {
                    if (val.Key == uservaluta)
                    {
                        newsum = sumofuservaluta * val.Value;
                        Console.WriteLine($"{sumofuservaluta} фунтов стерлингов = {newsum} {val.Key}");
                    }
                }

            }
            if (valuta == valuta.USD)
            {
                Valuta.USDRate();
                foreach (KeyValuePair<string, double> val in Valuta.rate)
                {
                    if (val.Key == uservaluta)
                    {
                        newsum = sumofuservaluta * val.Value;
                        Console.WriteLine($"{sumofuservaluta} дол = {newsum} {val.Key}");
                    }
                }

            }
            if (valuta == valuta.EUR)
            {
                Valuta.EURRate();
                foreach (KeyValuePair<string, double> val in Valuta.rate)
                {
                    if (val.Key == uservaluta)
                    {
                        newsum = sumofuservaluta * val.Value;
                        Console.WriteLine($"{sumofuservaluta} евро = {newsum} {val.Key}");
                    }
                }

            }
        }
    }
}
