using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
   public static class Homework1
    {
        /// <summary>
        /// программa,которая справшивает какая погода на улице
        /// </summary>
        static public void GiveThetemperature()
        {
            Console.WriteLine("Какая сейчас погода на улице?");
            int temperature = int.Parse(Console.ReadLine());
            string result = HotorCold(temperature);      
                Console.WriteLine(result);
        }
        static public string HotorCold(int temperature)
        {
            string result = " ";
            if (temperature >= -20 && temperature <= 5)
                result = "Сейчас холодно";
            else if (temperature >= 6 && temperature <= 15)
                result = "Сейчас прохладно";
            else if (temperature >= 16 && temperature <= 20)
                result = "Сейчас тепло";
            else if (temperature >= 21 && temperature <= 35)
                result = "Сейчас жарко";
            else if (temperature >= 36 && temperature <= 45)
                result = "Сейчас очень жарко";
            else
                result = "Я не верю что такая погода может быть!";
            return result;
        }
        /// <summary>
        /// запрашивает год (4х значное число) и выводит к какому веку относится год
        /// </summary>
        static public void GetCentury()
        {
            Console.Write("Введите год : ");
            int year = int.Parse(Console.ReadLine());
            int century = CenturyIS(year);
            Console.WriteLine($"{year} год относится к {century} столетию ");
        }
        static public int CenturyIS(int year)
        {
            int century = year / 100;
            if (year % 100 > 0)
                century++;
            return century;
        }
        /// <summary>
        /// запрашивает 3 числа и выводит наибольший из них
        /// </summary>
        static public void MaxNum()
        {
            Console.WriteLine("Введите первое число : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число : ");
            int num3 = int.Parse(Console.ReadLine());
            int maxnum = GetMaxNum(num1,num2,num3);
            if (maxnum == 0)
            {
                Console.WriteLine("Error");
            }
           Console.WriteLine($"Наибольшее число это {maxnum}");
        }
        static public int GetMaxNum(int num1, int num2, int num3)
        {
            int muxnum = 0;
            if (num1 >= num2 && num1 >= num3)
                muxnum = num1;
            else if (num2 >= num1 && num2 >= num3)
                muxnum = num2;
            else if (num3 >= num1 && num3 >= num2)
                muxnum = num3;
            return muxnum;

        }
        /// <summary>
        /// Программа запрашивает 2 числа. Выводит на экран их частное. При попытке разделить на 0, говорит,что на ноль делить нельзя
        /// </summary>
        static public void Devide2num()
        {
            Console.Write("Введите 1 число ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число ");
            int num2 = int.Parse(Console.ReadLine());
            int result = Devision(num1, num2);
            Console.WriteLine(result);
        }

        static public int Devision(int num1,int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        /// <summary>
        /// Магазин делает скидку от основной цены 50$, если стоимость покупки больше 500$, и 100$, если стоимость покупки больше 1000$.Программа запрашивает цену и возвращает цену со скидкой
        /// </summary>
        static public void GetDiscount()
        {
            Console.Write("Укажите цену товара : ");
            int price = int.Parse(Console.ReadLine());
            int newprice = GetNewPrice(price);
                Console.WriteLine($"Вы должны заплатить {newprice} $");
        }
        static public int GetNewPrice(int price)
        {
            int newprice;
            if (price > 500&& price<=1000)
                newprice = price - 50;
            else if (price > 1000)
                newprice = price - 100;
            else
                newprice = price;
            return newprice;
        }
    }
}
