using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
   public static class Homework1_before_courses
    {
        /// <summary>
        /// Если а – четное посчитать а*б, иначе а+б
        /// </summary>
        static public void if_else_1()
        {

            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = GetResultTo_if_else_1(a, b);
            Console.WriteLine(result);
        }
        static public int GetResultTo_if_else_1(int a, int b)
        {
            int result;
            if (a % 2 == 0)
                result = a * b;
            else
                result = a + b;
            return result;
        }
        /// <summary>
        /// 	Определить какой четверти принадлежит точка с координатами (х,у)
        /// </summary>
        static public void if_else_2()
        {

            Console.WriteLine("Введите значение х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            double y = double.Parse(Console.ReadLine());
            int quater = CheckQuater(x,y);
            Console.WriteLine($"Точка находится в {quater} четверти");
        }
        static public int CheckQuater(double x, double y)
        {
            int quater = 0;
            if (x > 0 && y > 0)
                quater = 1;
            if (x < 0 && y > 0)
                quater = 2;
            if (x < 0 && y < 0)
                quater = 3;
            if (x > 0 && y < 0)
                quater = 4;
            return quater;
        }
        /// <summary>
        /// Найти суммы только положительных из трех чисел
        /// </summary>
        static public void if_else_3()
        {
            Console.WriteLine("Введите число 1");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            double num3 = double.Parse(Console.ReadLine());
            double result = SumPositiveNumbers(num1,num2,num3);
            Console.WriteLine($"Сумма равна {result}");
        }
        static public double SumPositiveNumbers(double num1, double num2, double num3)
        {
            double result = 0;

            if (num1 > 0)
                result += num1;
            if (num2 > 0)
                result += num2;
            if (num3 > 0)
                result += num3;
            return result;
        }
        /// <summary>
        /// Посчитать выражение (макс(а*б*с, а+б+с))+3
        /// </summary>
        static public void if_else_4()
        {

            Console.WriteLine("Введите число 1");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            double num3 = double.Parse(Console.ReadLine());
            double result = GetResultforMathExample(num1, num2, num3);

            Console.WriteLine(result);
        }
        static public double GetResultforMathExample(double num1, double num2, double num3)
        {
            double sum = num1 + num2 + num3;
            double multiplication = num1 * num2 * num3;

            double result =sum > multiplication ? sum + 3 : multiplication + 3;
            return result;
        }
        /// <summary>
        /// Написать программу определения оценки студента по его рейтингу
        /// </summary>
        static public void if_else_5()
        {
            Console.WriteLine("Введите ваше место в рейтинге");
            int place = Convert.ToInt32(Console.ReadLine());
            char mark = GetMark(place);
                Console.WriteLine($"Ваша оценка {mark}");
        }
        static public char GetMark(int place)
        {
            char Mark = ' ';
            if (place > 0 && place < 20)
                Mark = 'F';
            else if (place >= 20 && place <= 39)
                Mark = 'E';
            else if (place >= 40 && place <= 59)
                Mark = 'D';
            else if (place >= 60 && place <= 74)
                Mark = 'C';
            else if (place >= 75 && place <= 89)
                Mark = 'B';
            else if (place >= 90 && place <= 100)
                Mark = 'A';
            return Mark;
        }
        /// <summary>
        /// Найти сумму четных чисел и их количество в диапазоне от 1 до 99
        /// </summary>
        static public void cicle_1()
        {
            uint countnumbers = 0;
            int sumnumbers = 0;
            for (int i = 1; i < 99; i++)
            {
                if (i % 2 == 0)
                {
                    countnumbers++;
                    sumnumbers += i;
                }
            }
            Console.WriteLine("Сумма четных чисел в диапазоне : " + sumnumbers);
            Console.WriteLine("Количество четных чисел в диапазоне: " + countnumbers);
            Console.ReadKey();

        }
        /// <summary>
        /// /Проверить простое ли число? (число называется простым, если оно делится только само на себя и на 1)
        /// </summary>
        static public void cicle_2()
        {
            Console.WriteLine("Введите число");
            double num = double.Parse(Console.ReadLine());
            if (num > 1)
            {
                if (num == 2)
                    Console.WriteLine("Число  является простым");
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("Число не является простым");
                    }
                    else
                    {
                        Console.WriteLine("Число  является простым");
                    }
                    break;
                }
            }
            else
                Console.WriteLine("Число не является простым");
        }
        /// <summary>
        /// метод бинарного поиска
        /// </summary>
        static public void Cicle_3_binary()
        {
            Console.Write("Введите число :\t ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Корень из числа: {num1} = {RootBinary(num1)} ");
        }
        /// <summary>
        /// метод бинарного поиска
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public int RootBinary(int number)
        {
            if (number == 0 || number == 1)
                return number;
            int right = 1;
            int left = number;
            int newmiddle = 0;
            while (right <= left)
            {
                int mid = (right + left) / 2;
                if (mid * mid == number)
                    return mid;
                if (mid * mid < number)
                {
                    right = mid + 1;
                    newmiddle = mid;
                }
                else
                    left = mid - 1;
            }
            return newmiddle;
        }
        /// <summary>
        /// вариант последовательного подбора
        /// </summary>
        static public void cicle_3_line()
        {
            Console.Write("Введите число :\t ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Корень из числа: {num} = {RootNumber(num)} ");
        }
        /// <summary>
        /// вариант последовательного подбора
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int RootNumber(int number)
        {
            for (int i = 1; ; i++)
            {
                int result = i * i;
                if (result == number)
                    return i;
                if (number < result)
                    return i - 1;
            }
        }
        /// <summary>
        /// факториал числа
        /// </summary>
        static public void Cicle_4()
        {
            Console.WriteLine("Введите число");
            ulong value = ulong.Parse(Console.ReadLine());
            ulong result = 1;
            for (ulong i = 1; i <= value; i++)
            {
                result *= i;
            }
            Console.WriteLine("Факториал числа " + value + " равен : " + result);
        }
        /// <summary>
        /// Посчитать сумму цифр заданного числа
        /// </summary>
        static public void Cicle_5()
        {
            Console.WriteLine("Введите число");
            int value = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = value; i > 0; i--)
            {
                result += value % 10;
                value /= 10;
            }
            Console.WriteLine("Сумма цифр равна " + result);
        }
        /// <summary>
        /// Вывести число, которое является зеркальным отображением последовательности цифр заданного числа
        /// </summary>
        static public void Cicle_6()
        {
            Console.WriteLine("Введите число: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Обратный вывод числа: ");
            for (; value != 0;)
            {
                Console.Write(value % 10 + " ");
                value /= 10;
            }
        }

        /// <summary>
        ///  Найти_индекс_min_max_элемента_массива
        /// </summary>
        static public void Array_1()
        {
            Console.WriteLine("Введите количество элементов массива : \t");
            int count = int.Parse(Console.ReadLine());
            int[] Myarray = new int[count];
            for (int i = 0; i < Myarray.Length; i++)
            {
                Console.WriteLine($"Введите значение для елемента массива с индексом  {i} :\t");
                Myarray[i] = int.Parse(Console.ReadLine());
            }
            int minvalue = Myarray[0];//5//6//7
            int maxvalue = Myarray[0];
            for (int i = 0; i < Myarray.Length; i++)
            {
                if (minvalue > Myarray[i])
                    minvalue = Myarray[i];
                else
                    if (maxvalue < Myarray[i])
                    maxvalue = Myarray[i];
            }
            Console.WriteLine("Индекс минимального елемента массива :\t" + MinIndex(Myarray, minvalue));
            Console.WriteLine("Индекс максимального елемента массива :\t" + MaxIndex(Myarray, maxvalue));
        }
        static int MinIndex(int[] array, int minvalue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == minvalue)
                    return i;
            }
            return -1;
        }
        static int MaxIndex(int[] array, int maxvalue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxvalue)
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// количество_нечетных_элементов_массива
        /// </summary>
        static public void Array_2()
        {
            Console.WriteLine("Введите количество элементов массива : \t");
            int count = int.Parse(Console.ReadLine());
            int[] Myarray = new int[count];
            for (int i = 0; i < Myarray.Length; i++)
            {
                Console.WriteLine($"Введите значение для елемента массива с индексом  {i} :\t");
                Myarray[i] = int.Parse(Console.ReadLine());

            }
            int number = 0;
            for (int i = 0; i < Myarray.Length; i++)
            {
                if (Myarray[i] % 2 == 0)
                    continue;
                else
                    number++;
            }
            Console.WriteLine("количество нечетных элементов массива : " + number);
        }
        /// <summary>
        /// Найти минимальный элемент массива_Найти максимальный элемент массива
        /// </summary>
        static public void Array_3()
        {
            Console.Write("Введите количество елементов массива : \t");
            int elements = int.Parse(Console.ReadLine());
            int[] MyArray = new int[elements];

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"\n Введите значение для елемента массива с индексом {i} : \t");
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            int minvalue = MyArray[0];
            int maxvalue = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
            {
                if (MyArray[i] < minvalue)
                    minvalue = MyArray[i];
                else if (MyArray[i] > maxvalue)
                    maxvalue = MyArray[i];
            }
            Console.WriteLine($"Минимальный элемент массива : {minvalue}");
            Console.WriteLine($"Максимальный элемент массива : {maxvalue}");
        }

        /// <summary>
        /// Поменять_местами_первую_и_вторую_половину_массива
        /// </summary>
        static public void Array_4()
        {
            Console.WriteLine("Укажите колличество елементов массива : ");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            Console.WriteLine("Укажите максимальный елемент массива : ");
            int maxelement = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(maxelement);
            Console.WriteLine("Исходный массив : ");
            foreach (var item in array)
                Console.Write(item + "\t");
            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length / 2 + i];
                array[array.Length / 2 + i] = temp;
            }
            Console.WriteLine("\nМассив после изменения : ");
            foreach (var item in array)
                Console.Write(item + "\t");
        }
        /// <summary>
        /// Сделать реверс массива
        /// </summary>
        static public void Array_5()
        {
            Console.Write("\nВведите количество елементов массива : ");
            int elements = int.Parse(Console.ReadLine());
            int[] MyArray = new int[elements];
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"\nВведите значение для елемента массива с индексом {i} : ");
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = MyArray.Length - 1; i >= 0; --i)
                Console.Write(MyArray[i] + " ");
        }
        /// <summary>
        /// Cумма элементов массива с нечетными индексами
        /// </summary>
        static public void Array_6()
        {
            Console.WriteLine("Введите количество элементов массива : \t");
            int count = int.Parse(Console.ReadLine());
            int[] Myarray = new int[count];
            for (int i = 0; i < Myarray.Length; i++)
            {
                Console.WriteLine($"Введите значение для елемента массива с индексом  {i} :\t");
                Myarray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма элементов массива с нечетными индексами равна \t" + SumOfElements(Myarray));
        }
        static int SumOfElements(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    continue;
                else
                    sum += array[i];
            }
            return sum;
        }
        /// <summary>
        /// Отсортировать_массив(методом пузырька (Bubble)
        /// </summary>
        static public void Array_7_bubble()
        {
            int[] Myarray = new int[10];
            Random random = new Random();
            for (int i = 0; i < Myarray.Length; i++)
                Myarray[i] = random.Next(100);
            Console.WriteLine("Массив до сортировки : ");
            foreach (var item in Myarray)
                Console.Write(item + "\t");
            int prev;
            for (int i = 1; i < Myarray.Length; i++)
            {
                for (int j = 0; j < Myarray.Length - 1; j++)
                {
                    if (Myarray[j] > Myarray[j + 1])
                    {
                        prev = Myarray[j];
                        Myarray[j] = Myarray[j + 1];
                        Myarray[j + 1] = prev;
                    }
                }
            }
            Console.WriteLine("\nМассив после сортировки : ");
            foreach (var item in Myarray)
                Console.Write(item + "\t");
        }
        /// <summary>
        /// Отсортировать_массив(выбором (Select)
        /// </summary>
        static public void Array_7_Select()
        {
            Console.WriteLine("Укажите колличество елементов массива : ");
            int size = int.Parse(Console.ReadLine());
            int[] Array = new int[size];
            Console.WriteLine("Укажите максимальный елемент массива : ");
            int maxvalue = int.Parse(Console.ReadLine());
            Random random1 = new Random();
            for (int i = 0; i < Array.Length; i++)
                Array[i] = random1.Next(maxvalue);
            Console.WriteLine("Массив до сортировки : ");
            foreach (var item in Array)
                Console.Write(item + "\t");
            int prv;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[i])
                    {
                        prv = Array[i];
                        Array[i] = Array[j];
                        Array[j] = prv;
                    }
                }
            }
            Console.WriteLine("\nМассив после сортировки : ");
            foreach (var item in Array)
                Console.Write(item + "\t");
            Console.ReadLine();
        }
        /// <summary>
        /// Отсортировать_массив(вставками(Insert))
        /// </summary>
        static public void Array_7_Insert()
        {
            Console.WriteLine("Укажите колличество елементов массива : ");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            Console.WriteLine("Укажите максимальный елемент массива : ");
            int maxvalue = int.Parse(Console.ReadLine());
            Random random2 = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random2.Next(maxvalue);
            Console.WriteLine("Массив до сортировки : ");
            foreach (var item in array)
                Console.Write(item + "\t");
            for (int i = 1; i < array.Length; i++)
            {
                int pastelement = array[i];
                while (i > 0 && array[i - 1] > pastelement)
                {
                    array[i] = array[i - 1];
                    i--;
                }
                array[i] = pastelement;
            }
            Console.WriteLine("\nМассив после сортировки : ");
            foreach (var item in array)
                Console.Write(item + "\t");
            Console.ReadLine();
        }
        /// <summary>
        /// Вводим строку.Получить само число
        /// </summary>
        static public void Function_1()
        {
            Console.WriteLine("Введите число от 0 до 999");
            string number = Console.ReadLine();
            Console.WriteLine("Ваше число это " + RecipeToNum(number));
        }
        static public string[][] numbers =
      {
            new string[2] {"ноль",  "0"},
            new string[2] {"один",  "1"},
            new string[2] {"два",  "2"},
            new string[2] {"три", "3"},
            new string[2] {"четыре", "4"},
            new string[2] {"пять", "5"},
            new string[2] {"шесть", "6"},
            new string[2] {"семь", "7"},
            new string[2] {"восемь", "8"},
            new string[2] {"девять", "9"},
            new string[2] {"десять", "10"},
            new string[2] {"одиннадцать", "11"},
            new string[2] {"двенадцать", "12"},
            new string[2] {"тринадцать", "13"},
            new string[2] {"четырнадцать", "14"},
            new string[2] {"пятнадцать", "15"},
            new string[2] {"шестнадцать", "16"},
            new string[2] {"семнадцать", "17"},
            new string[2] {"восемьдесять", "18"},
            new string[2] {"девятнадцать", "19"},
            new string[2] {"двадцать", "20"},
            new string[2] {"тридцать", "30"},
            new string[2] {"сорок", "40"},
            new string[2] {"пятьдесят", "50"},
            new string[2] {"шестьдесят", "60"},
            new string[2] {"семьдесят", "70"},
            new string[2] {"восемьдесят", "80"},
            new string[2] {"девяносто", "90"},
            new string[2] {"сто", "100"},
            new string[2] {"двесте", "200"},
            new string[2] {"триста", "300"},
            new string[2] {"четыреста", "400"},
            new string[2] {"пятьсот", "500"},
            new string[2] {"шестьсот", "600"},
            new string[2] {"семьсот", "700"},
            new string[2] {"восемьсот", "800"},
            new string[2] {"девятьсот", "900"}
       };

        static decimal RecipeToNum(string text)
        {
            string[] words = text.Split();
            uint[] num = new uint[words.Length];
            int number = 0;
            int temp = 0;
            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < words.Length; k++)
                {
                    if (words[k] == numbers[i][j])
                    {
                        temp = int.Parse(numbers[i][1]);
                        number += temp;
                    }
                }
            }
            return number;
        }

        /// <summary>
        /// водим число(0-999), получаем строку с прописью числа
        /// </summary>
        static public void Function_2()
        {
            Console.WriteLine("Введите число от 0 до 999");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Ваше число это " + NumberToString(number));
        }
        static string NumberToString(uint number)
        {
            string[] units = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] tens = { "десять", "давдцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] hundrends = { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] tentotwenty = { "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

            string result = "";
            uint n = number;
            uint[] value = new uint[3];
            value[0] = n % 10;
            value[1] = (n / 10) % 10;
            value[2] = n / 100;
            if (value[2] > 0)
                result += (hundrends[value[2] - 1] + " ");

            if (value[1] > 0)
            {
                if (value[1] == 1 && value[0] != 0)
                {
                    result += (tentotwenty[value[0] - 1] + " ");
                    return result;
                }
                else
                    result += (tens[value[1] - 1] + " ");
            }
            if (value[0] > 0)
                result += (units[value[0] - 1] + " ");

            return result;
        }
        /// <summary>
        /// Найти_расстояние_между_двумя_точками
        /// </summary>
        static public void Function_3()
        {
            Console.WriteLine("Укажите координаты Х и Y для первой точки : ");
            Console.Write("Х = ");
            double X1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Y = ");
            double Y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Укажите координаты Х и У для второй точки : ");
            double X2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Расстояние между точками " + PointTopointDistance(X1, Y1, X2, Y2));
        }
        static double PointTopointDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
        }
        /// <summary>
        /// строковое название дня недели по номеру дня
        /// </summary>
        static public void Function_4()
        {
            Console.Write("Укажите номер дня : ");
            int daynumber = int.Parse(Console.ReadLine());
            Console.Write(daynumber + " день недели это ");
            DayOfTheWeek(daynumber);
        }
        static void DayOfTheWeek(int daynumber)
        {
            switch (daynumber)
            {
                case 1:
                    Console.WriteLine("Понедельник.");
                    break;
                case 2:
                    Console.WriteLine("Вторник.");
                    break;
                case 3:
                    Console.WriteLine("Среда.");
                    break;
                case 4:
                    Console.WriteLine("Четверг.");
                    break;
                case 5:
                    Console.WriteLine("Пятница.");
                    break;
                case 6:
                    Console.WriteLine("Суббота.");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье.");
                    break;

                default:
                    Console.WriteLine("неизвестный мне день.");
                    break;
            }
        }
    }


}
