using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
  public static  class Homework4
    {
        /// <summary>
        /// Простой но надежный калькулятор
        /// </summary>
        static public void Calculator()
        {
            Calculator_HW4();
        }
        static public void SetData(out int num2, out char sign)
        {
            Console.WriteLine("Введите 2 число");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите действие в виде знака + - / * ");
            sign = char.Parse(Console.ReadLine());
            if ((num2 == 0 && sign == '/') || (sign != '/' && sign != '*' && sign != '+' && sign != '-'))
            {
                Console.WriteLine("Error");
                SetData(out num2, out sign);
            }

        }
        static public int Calculate(int num1, int num2, char sign)
        {
            int result = 0;
            switch (sign)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
            }
            return result;
        }
        public enum Answer
        {
            New,
            Continue,
            End
        }
        static public Answer IsCalculateFinish()
        {
            Console.WriteLine("Введите New если хотите начать новые вычесления, Continue если хотите продолжить вычесления и End если хотите завершить");
            Answer answer = (Answer)Enum.Parse(typeof(Answer), Console.ReadLine());
            return answer;
        }
        static public int SetNum1()
        {
            Console.WriteLine("Введите 1 число");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static public void Calculator_HW4()
        {
            int num1;
            char sign;
            Answer answer = Answer.New;
            while (answer == Answer.New)
            {
                num1 = SetNum1();
                answer = Answer.Continue;
                while (answer == Answer.Continue)
                {
                    SetData(out int num2, out sign);
                    num1 = Calculate(num1, num2, sign);
                    Console.WriteLine(num1);
                    answer = IsCalculateFinish();
                }
            }
        }
        /// <summary>
        /// Книга имен,с возможностью удалять,добавлять имена и просматривать всю книгу
        /// </summary>
        static public void NameBook()
        {
            string[] namebook = new string[10] { "Иван", "Наталия", "Сергей", "Виталий", "Татьяна", "John", "Olha", "Valeriy", "Anastasiya", "Veronika" };
            string[] newarray = new string[namebook.Length + 1];
            while (true)
            {
                Console.WriteLine("Укажите действие : \nдобавить имя\nудалить имя\nвывести весь список имен");
                Console.WriteLine();
                string answer = Console.ReadLine();
                Console.Clear();
                if (answer.Contains("добавить"))
                {
                    Console.WriteLine("Укажите имя,которое вы хотите добавить");
                    string name = Console.ReadLine();
                    newarray = Addname( namebook, name);
                    Console.Clear();
                }
                else if (answer.Contains("удалить"))
                {
                    Console.WriteLine("Укажите имя,которое вы хотите удалить");
                    string name = Console.ReadLine();
                    namebook =Removename(namebook, name);
                    Console.Clear();
                }
                else if (answer.Contains("вывести"))
                {
                    ShowAll(namebook);
                    Console.WriteLine();
                }
            }
        }
        static public string[] Removename(string[] array, string name, int index = 0)
        {
            string[] newarray = new string[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == name)
                    index = i;
            }
            for (int i = 0; i < index; i++)
            {
                newarray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newarray[i - 1] = array[i];
            }
            array = newarray;
            return array;
        }
        static public string[] Addname( string[] array, string name, int index = 0)
        {
            string[] newarray = new string[array.Length + 1];
            newarray[index] = name;
            for (int i = index+1; i < newarray.Length; i++)
            {
                newarray[i] = array[i-1];
            }
            array = newarray;
            return array;
        }
        static public void ShowAll(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + "   ");
            }
        }
        /// <summary>
        /// Расчитать периметр,радиус и площадь круга
        /// </summary>
        static public void perimetr_area_radius()
        {
            Console.WriteLine("Какую что именно вы хотите посчитать: периметр, площадь или радиус");
            string answer = Console.ReadLine();
            if (answer.Contains("периметр"))
            {
                Console.WriteLine("Укажите радиус окружности");
                double radius = double.Parse(Console.ReadLine());
                double result = 0;
                perimeter(radius, out result);
                Console.WriteLine("Периметр равен " + result);

            }
            else if (answer.Contains("площадь"))
            {
                Console.WriteLine("Укажите радиус окружности");
                double radius = double.Parse(Console.ReadLine());
                double result = 0;
                area(radius, out result);
                Console.WriteLine("Площадь равна " + result);
            }
            else if (answer.Contains("радиус"))
            {
                Console.WriteLine("Укажите длину окружности");
                double length = double.Parse(Console.ReadLine());
                double result = 0;
                radius(length, out result);
                Console.WriteLine("Площадь равна " + result);
            }
           
        }
        static public void perimeter(double radius, out double result)
        {
            result = 2 * 3.14 * radius;
        }
        static public void area(double radius, out double result)
        {
            result = 3.14 * radius * radius;
        }
        static public void radius(double length, out double result)
        {
            result = length / (2 * Math.PI);
        }
        /// <summary>
        ///Метод вывода фигур из ноликов
        /// </summary>
        static public void PrintFigure()
        {
            Console.WriteLine("Укажите,что цифру под которой указана фигура,которую вы хотите нарисовать : 1-квадрат, 2-треугольник прямоугольный ,3-треугольник равносторонний, 4-перевернутые треугольники, 5 - песочные часы ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                PrintSquare();
            else if (choice == 2)
                Printtriangle1();
            else if (choice == 4)
                Printreversetriangle1();
            else if (choice == 3)
                Printtriangle2();
            else if (choice == 5)
                Printhourglass();
        }
        static public void PrintSquare()
        {
            Console.Write("Укажите длину стороны квадрата : ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
        static public void Printtriangle1()
        {
            Console.Write("Укажите высоту треугольника : ");
            int high = int.Parse(Console.ReadLine());
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }

        static public void Printreversetriangle1()
        {
            Console.Write("Укажите высоту треугольника : ");
            int high = int.Parse(Console.ReadLine());
            for (int i = 0; i < high; i++)
            {
                for (int j = high; j > i; j--)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }


        static public void Printtriangle2()
        {
            Console.Write("Укажите высоту треугольника : ");
            int high = int.Parse(Console.ReadLine());
            int i, j;
            for (i = 0; i < high; i++)
            {
                for (j = high - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= 2 * i; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }
        static public void Printhourglass()
        {
            Console.Write("Укажите высоту песочных часов : ");
            int high = int.Parse(Console.ReadLine());
            int x, y;
            for (y = 0; y <= high; y++)
            {
                Console.Write(" ");
                for (x = 0; x <= high; x++)
                {
                    if (y <= x && (y <= high - x) || (y >= high - x) && y >= x)
                        Console.Write("0");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


    }


    
}
