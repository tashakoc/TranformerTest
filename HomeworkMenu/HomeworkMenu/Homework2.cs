using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class Homework2
    {
        /// <summary>
        /// Вводим дату словами(пример: двадцать первое марта 1999-го года), на экран выводится дата цифрами в указанном формате(дд.мм.гггг).
        /// </summary>
        static public void PrintDate()
        {
            Console.WriteLine("Введите дату");
            string data = Console.ReadLine();
            var newdata = data.Split(" ");
            string newday = "";
            var day = newdata.Length > 4 ? newdata[0] + " " + newdata[1] : newdata[0];
            string[] num = { "первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое", "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцатое", "шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое", "двадцатое", "двадцать первое", "двадцать второе", "двадцать третье", "двадцать четвёртое", "двадцать пятое", "	двадцать шестое", "двадцать седьмое", "	двадцать восьмое", "двадцать девятое", "тридцатое", "тридцать первое" };

            for (int i = 0; i < num.Length; i++)
                if (num[i] == day)
                    newday = i < 9 ? $"0{i + 1}" : $"{i + 1}";
            var month = newdata[^3];
            switch (month)
            {
                case "января":
                    month = "01";
                    break;
                case "февраля":
                    month = "02";
                    break;
                case "марта":
                    month = "03";
                    break;
                case "апреля":
                    month = "04";
                    break;
                case "мая":
                    month = "05";
                    break;
                case "июня":
                    month = "06";
                    break;
                case "июля":
                    month = "07";
                    break;
                case "августа":
                    month = "08";
                    break;
                case "сентября":
                    month = "09";
                    break;
                case "октября":
                    month = "10";
                    break;
                case "ноября":
                    month = "11";
                    break;
                case "декабря":
                    month = "12";
                    break;
            }
            var year = newdata[^2].Split('-')[0];
            Console.WriteLine($"{newday}.{month}.{year}.");
        }
        /// <summary>
        /// простой калькулятор, который может при вводе строке в виде‘отними 123 от 31’ выводит результат вычисления.Математические операции, которыедолжен уметь делать: +, -, /, *.
        /// </summary>
        static public void SimpleCalculator()
        {
            Console.WriteLine("Введите что мне нужно сделать");
            string whattodo = Console.ReadLine();
            var splitstring = whattodo.Split(" ");
            int num1 = int.Parse(splitstring[1]);
            int num2 = int.Parse(splitstring[3]);
            var somechar = splitstring[0];

            if (somechar.Contains('О') || somechar.Contains('о'))
                Console.WriteLine(num2 - num1);
            else if (somechar.Contains('с') || somechar.Contains('С'))
                Console.WriteLine(num2 + num1);
            else if (somechar.Contains('р') || somechar.Contains('Р'))
                Console.WriteLine(num1 / num2);
            else if (somechar.Contains('у') || somechar.Contains('У'))
                Console.WriteLine(num2 * num1);
            else if (somechar.Contains('р') || somechar.Contains('Р') || num2 == 0)
                Console.WriteLine("На ноль делить нельзя");
        }
        /// <summary>
        /// Нужно удалить из строки лишние пробелы, изменить имя Гриша на Григорий, и номер заказа ‘#123123’ удалить вместе с ненужными пробелами.
        /// </summary>
        static public void HelloGrisha()
        {
            Console.WriteLine("Добрый день, Григорий, ваш заказ находится в обработке");
        }
        /// <summary>
        /// Найти кол-во дубликатов "я" в предложении и вывести их кол-во
        /// </summary>
        static public void FindDuplicate()
        {
            string sentence = "Вчера я был на речке, там я купался и загорал, из - за того, что я уснул, то я очень обгорел.";
            var splitsentence = sentence.Split(" ");
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < splitsentence.Length; i++)
            {
                if (splitsentence[i] == ("я"))
                    count1++;
                if (splitsentence[i].Contains('я'))
                    count2++;
            }
            Console.WriteLine($"Количество дубликатов {count1} \n Общее количество букв <я> {count2}");
        }
        /// <summary>
        /// Ввести 4 строки в консоль.Вывести на консоль те строки, длина которых меньше средней и также содержит в себе слово палиндром, при этом вывести также их длину, если таковых нет, то вывести сообщение об этом
        /// </summary>
        static public void FindPalindrom()
        {
            Console.WriteLine("Введите 1 строку");
            string string1 = Console.ReadLine();
            Console.WriteLine("Введите 2 строку");
            string string2 = Console.ReadLine();
            Console.WriteLine("Введите 3 строку");
            string string3 = Console.ReadLine();
            Console.WriteLine("Введите 4 строку");
            string string4 = Console.ReadLine();

            int sumoflenth = string1.Length + string2.Length + string3.Length + string4.Length;
            int average = sumoflenth / 4;
            string result = "";
            string paleendrom1 = "";
            string paleendrom2 = "";
            string paleendrom3 = "";
            string paleendrom4 = "";
            var splitstring1 = string1.Split(" ");

            for (int i = splitstring1.Length - 1; i >= 0; i--)
            {
                var revs = splitstring1[i];
                if (splitstring1[i] == revs)
                    paleendrom1 = "true";
            }

            var splitstring2 = string2.Split(" ");
            for (int i = splitstring2.Length - 1; i >= 0; i--)
            {
                var revs = splitstring2[i];
                if (splitstring2[i] == revs)
                    paleendrom2 = "true";
            }
            var splitstring3 = string3.Split(" ");
            for (int i = splitstring3.Length - 1; i >= 0; i--)
            {
                var revs = splitstring3[i];
                if (splitstring3[i] == revs)
                    paleendrom3 = "true";
            }
            var splitstring4 = string4.Split(" ");
            for (int i = splitstring4.Length - 1; i >= 0; i--)
            {
                var revs = splitstring4[i];
                if (splitstring4[i] == revs)
                    paleendrom1 = "true";
            }

            if (string1.Length < average && paleendrom1 == "true")
                result += ($"Строка : {string1} cooтветствует условию, ее длина составляет {string1.Length} символов вместе с пробелами и знаками препинания\n");
            if (string1.Length < average && paleendrom2 == "true")
                result += ($"Строка :  {string2} cooтветствует условию, ее длина составляет {string2.Length} символов вместе с пробелами и знаками препинания\n");
            if (string3.Length < average && paleendrom3 == "true")
                result += ($"Строка : {string3} cooтветствует условию, ее длина составляет {string3.Length} символов вместе с пробелами и знаками препинания\n");
            if (string4.Length < average && paleendrom4 == "true")
                result += ($"Строка : {string4} cooтветствует условию, ее длина составляет {string4.Length} символов вместе с пробелами и знаками препинания\n");
            if (result.Equals(""))
                result = "Нет строк подходящих под условие задачи";

            Console.WriteLine(result);
        }
        /// <summary>
        /// Из введенной строки необходимо удалить все записи на транслите, выделить каждое имя собственное как обращение и все большие буквы стоящие в середине слова заменить на маленькие
        /// </summary>
        static public void ChangeString()
        {
            Console.WriteLine("Введите строку");
            string userstring = Console.ReadLine();
            var splitedstring = userstring.Split(' ');
            var resulstring = "";
            for (int i = 0; i < splitedstring.Length; i++)
            {
                var word = splitedstring[i];
                string prev = "";
                var wordchars = word.ToCharArray();
                foreach (var ch in wordchars)
                {
                    if (!(ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                        prev = prev + ch;
                }
                word = prev;

                bool addSpace = i != 0;
                if (i != 0 && Char.IsUpper(wordchars[0]))
                {
                    addSpace = false;
                    word = ", " + word + ",";
                }
                else
                {
                    if (word.Length < 3)
                        word = word;
                    else
                    {
                        var first = word.Substring(0, 1);
                        var last = word.Substring(word.Length - 1);
                        var mid = word.Substring(1, word.Length - 2).ToLower();
                        word = first + mid + last;
                    }
                }
                resulstring = resulstring + (addSpace ? " " : "") + word;
            }
            Console.WriteLine(resulstring);
        }
    }
}
