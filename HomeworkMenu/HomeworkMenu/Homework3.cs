using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class Homework3
    {
        /// <summary>
        /// //Заполнить массив из 20 елементов числами Фибоначии и вывести их на экран
        /// </summary>
        static public void Fibbonachi()
        {
            int[] array = new int[20];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < 20; i++)
                array[i] = array[i - 1] + array[i - 2];
            foreach (var item in array)
                Console.Write($"{item}\t");
        }

        /// <summary>
        /// Выводить все элементы массива пока не встретится элемент с не положительным значением. (Массив задает пользователь)
        /// </summary>
        static public void PrintPosiveArrayNum()
        {
            Console.Write("\nВведите количество елементов массива : ");
            int elements = int.Parse(Console.ReadLine());
            int[] MyArray = new int[elements];
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"\nВведите значение для елемента массива с индексом {i} : ");
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in MyArray)
            {
                if (item < 0)
                    break;
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Необходимо добавить элемент в конец или начало массива (выбирает пользователь) и вывести весь массив в консоль
        /// </summary>
        static public void AddElementToArray()
        {
            var array = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };
            Console.WriteLine("Массив до изменения : ");
            foreach (var item in array)
                Console.Write($"{item} \t");
            Console.WriteLine();
            Console.WriteLine("Укажите елемент, который вы хотите довавить в массив");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Мне добавить этот елемент в конец или в начало?");
            string answer = Console.ReadLine();
            int index = 0;
            if (answer == "в конец")
                index = array.Length;
            Insertelement(ref array, value, index);
            Console.WriteLine("Массив после изменений : ");
            foreach (var item in array)
                Console.Write(item + "\t");
        }
        static public void Insertelement(ref int[] myarray, int value, int index)
        {
            int[] newarray = new int[myarray.Length + 1];
            newarray[index] = value;
            for (int i = 0; i < index; i++)
                newarray[i] = myarray[i];
            for (int i = index; i < myarray.Length; i++)
            {
                newarray[i + 1] = myarray[i];
            }
            myarray = newarray;
        }
        /// <summary>
        /// Вывести сумму всех чисел двумерного массива
        /// </summary>
        static public void SumOFArray()
        {
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
        /// <summary>
        ///  Вывести двумерный массив в консоль, чтобы элементы располагались в виде матрицы.
        /// </summary>
        static public void PrintMatrix()
        {
            Console.Write("\nВведите количество елементов во 2 ранке двумерного массива : ");
            int elements = int.Parse(Console.ReadLine());
            int[,] MyArray = new int[2, elements];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < elements; j++)
                {
                    Console.Write($"\nВведите значение для елемента массива с индексом {i}.{j} : ");
                    MyArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < MyArray.Length / 2; j++)
                {
                    Console.Write(MyArray[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Вывести двумерный массив в консоль, чтобы элементы располагались в виде матрицы, негативные цифры не должны выводиться
        /// </summary>
        static public void PrintMatrixWithoutNegativeNum()
        {
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            int rows = array.GetUpperBound(0) + 1;
            int column = array.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array[i, j] < 0)
                        continue;
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Пользователь вводит строку и в ответ ему должно выводиться сколько слов, которые начинаются с заглавной буквы находятся в предложении и также выводятся все эти слова через запятую.
        /// </summary>
        static public void FindUpperWord()
        {
            Console.WriteLine("Введите строку : ");
            string userstring = Console.ReadLine();
            string[] splitstring = userstring.Split(" ");
            int count = 0;
            string wordupper = "";
            for (int i = 0; i < splitstring.Length; i++)
            {
                var word = splitstring[i];
                var wordchar = word.ToCharArray();
                if (Char.IsUpper(wordchar[0]))
                {
                    count++;
                    wordupper += $"{word}, ";
                }
            }
            Console.WriteLine($"Количество слов , которые начинаются с заглавной буквы = {count}\n Это следущие слова {wordupper}");
        }
        /// <summary>
        /// Пользователь вводит 6 своих последних зарплат, ему выводится максимальная, минимальная, средняя зп и общая сумма.
        /// </summary>
        static public void CalculationOfSalary()
        {
            int[] salary = new int[6];
            Console.WriteLine("Введите 6 своих последних зарплат");
            for (int i = 0; i < salary.Length; i++)
            {
                salary[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int maxsalary = salary[0];
            int minsalary = salary[0];
            for (int i = 0; i < salary.Length; i++)
            {
                if (maxsalary < salary[i])
                    maxsalary = salary[i];
                else if (minsalary > salary[i])
                    minsalary = salary[i];
                sum += salary[i];
            }
            int averagesalary = sum / 6;
            Console.WriteLine($"Минимальная ЗП это {minsalary}\nМаксимальная ЗП это {maxsalary}\nСредняя ЗП равна {averagesalary}\nОбщая сумма равна {sum}");
        }
        /// <summary>
        /// Пользователь может ввести сколько угодно данных в таблицу/Если он напишет stop, то программа выведет ему все данные
        /// </summary>
        static public void PrintTableOfData()
        {
            string[,] array = new string[,] { { "| Age |", "First Name |", "Second Name |", " City |" }, { "", "", "", "" } };
            Console.WriteLine("Введите свои данные в формате | Age | First Name | Second Name | City | ");
            for (int i = 1; i == 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string userstring = Console.ReadLine();
                    array[i, j] += $"| {userstring} |";
                    if (array[i, j].Contains("stop"))
                        break;
                }
            }
            int rows = array.GetUpperBound(0) + 1;
            int column = array.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// * С шансом 5% в массив должно попадать число -1. Это число всегда должно устанавливаться в самый центр матрицы.
        /// </summary>
        static public void GuessTheNumHard()
        {
            string[,] charaaray = new string[5, 5];
            int[,] array = new int[5, 5];
            int rows = array.GetUpperBound(0) + 1;
            int column = array.GetUpperBound(1) + 1;
            int rows2 = charaaray.GetUpperBound(0) + 1;
            int column2 = charaaray.GetUpperBound(1) + 1;
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    charaaray[i, j] = "*";
                }
            }
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    int result;
                    int chance = random.Next(1, 21);
                    if (chance <= 5)
                        result = random.Next(2);
                    else
                        result = random.Next(2, 20);
                    if (result == 1)
                    {
                        array[2, 2] = 1;


                        break;
                    }

                    array[i, j] = result;

                }
            }
        start:
            Console.WriteLine("Попробуйте угадать значение из массива!Введите число от 0 до 20: ");
            string answer = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    string ch = Convert.ToString(array[i, j]);
                    if (answer == ch)
                    {
                        for (int w = i; w < rows2; w++)
                        {
                            for (int q = j; q < column2; q++)
                            {
                                charaaray[w, q] = ch;
                                break;
                            }
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    Console.Write($"{ charaaray[i, j]}\t");
                }
                Console.WriteLine();
            }
            goto start;
        }
        /// <summary>
        /// Создать двумерный массив 5х5.Заполнить случайными значениями от 0 до 20.НЕ показывать пользователю. Спрашивать по одному числу у пользователя
        /// </summary>
        static public void GuessTheNum()
        {
            string[,] charaaray = new string[5, 5];
            int[,] array = new int[5, 5];
            Random random = new Random();
            int rows = array.GetUpperBound(0) + 1;
            int column = array.GetUpperBound(1) + 1;
            int rows2 = charaaray.GetUpperBound(0) + 1;
            int column2 = charaaray.GetUpperBound(1) + 1;
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    charaaray[i, j] = "*";
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(20);
                }
            }
        start:
            Console.WriteLine("Попробуйте угадать значение из массива!Введите число от 0 до 20: ");
            string answer = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    string ch = Convert.ToString(array[i, j]);
                    if (answer == ch)
                    {
                        for (int w = i; w < rows2; w++)
                        {
                            for (int q = j; q < column2; q++)
                            {
                                charaaray[w, q] = ch;
                                break;
                            }
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    Console.Write($"{ charaaray[i, j]}\t");
                }
                Console.WriteLine();
            }
            goto start;
        }
        /// <summary>
        /// //1.Убрать все спец.символы в словах массива.2.Убрать все цифры кроме нулей, убрать все лишние пробелы.3.Все единицы заменить на t.4.Результат вывести в консоль через пробелы.
        /// </summary>
        static public void ChangeArray()
        {
            var array = new[, ,] { { { "(((&Y@#06u%^&", "m6u%$^s!1", " t0" }, { "k@!!^n0!@w", "?*()h0&&w", "!1#$!0*" }, { " !@#w0)(r&*(&k ", "&*w*i61^h%", "a@#$r$$$$r@ay#%s" }, { "!@a@!##@n!@#!@d##", "w*i61^h%", "!@#!$%$c!@#!y^&*^&*c$%^l$%^e$%^s!#@!@" } } };
            int rows = array.GetUpperBound(0) + 1;
            int column = array.GetUpperBound(1) + 1;
            int column2 = array.GetUpperBound(2) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int f = 0; f < column2; f++)
                    {
                        array[i, j, f] = Regex.Replace(array[i, j, f], "[^\\w\\.]", "");
                        array[i, j, f].Trim();
                        array[i, j, f] = Regex.Replace(array[i, j, f], "[2-9]", "");
                    }

                }
            }
            string word = "";
            string world1 = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int f = 0; f < column2; f++)
                    {
                        var wordchars = array[i, j, f].ToCharArray();
                        for (int d = 0; d < wordchars.Length; d++)
                        {
                            if (wordchars[d] == '1')
                            { wordchars[d] = 't'; }
                            word += wordchars[d];
                        }
                        world1 += word + " ";
                        word = "";
                    }
                }
            }
            Console.WriteLine(world1);
        }


        static public void Maze()
        {
            Console.WriteLine("Введите размерность 1 ранга массива");
            Console.WriteLine("Введите размерность 2 ранга массива");
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            List<List<int>> maze = new List<List<int>>();
            List<int> row = new List<int>();


            for (int i = 0; i < width; i++)
            {
                row = new List<int>();
                for (int j = 0; j < height; j++) row.Add(i + j);
                maze.Add(row);
            }
            mazemake(maze, height, width);
            visual(maze, height, width);
        }
        static Random rand = new Random();


        const int wall = 0, pass = 1;
        static bool deadend(int x, int y, List<List<int>> maze, int height, int width)
        {
            int a = 0;

            if (x != 1)
            {
                if (maze[y][x - 2] == pass)
                    a += 1;
            }
            else a += 1;

            if (y != 1)
            {
                if (maze[y - 2][x] == pass)
                    a += 1;
            }
            else a += 1;

            if (x != width - 2)
            {
                if (maze[y][x + 2] == pass)
                    a += 1;
            }
            else a += 1;

            if (y != height - 2)
            {
                if (maze[y + 2][x] == pass)
                    a += 1;
            }
            else a += 1;

            if (a == 4)
                return true;
            else
                return false;
        }



        static void visual(List<List<int>> maze, int height, int width)
        {
            for (int i = 2; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    switch (maze[i][j])
                    {
                        case wall: Console.Write("|"); break;
                        case pass: Console.Write(" "); break;
                    }
                Console.WriteLine();
            }
            Console.WriteLine();

        }



        static public void mazemake(List<List<int>> maze, int height, int width)
        {
            int x, y, c, a;
            bool b;

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    maze[i][j] = wall;

            x = 3; y = 3; a = 0;
            while (a < 10000)
            {
                maze[y][x] = pass; a++;
                while (true)
                {
                    c = rand.Next() % 4;
                    switch (c)
                    {
                        case 0:
                            if (y != 1)
                                if (maze[y - 2][x] == wall)
                                { // Вверх
                                    maze[y - 1][x] = pass;
                                    maze[y - 2][x] = pass;
                                    y -= 2;
                                }
                            break;
                        case 1:
                            if (y != height - 2)
                                if (maze[y + 2][x] == wall)
                                { // Вниз
                                    maze[y + 1][x] = pass;
                                    maze[y + 2][x] = pass;
                                    y += 2;
                                }
                            break;
                        case 2:
                            if (x != 1)
                                if (maze[y][x - 2] == wall)
                                { // Налево
                                    maze[y][x - 1] = pass;
                                    maze[y][x - 2] = pass;
                                    x -= 2;
                                }
                            break;
                        case 3:
                            if (x != width - 2)
                                if (maze[y][x + 2] == wall)
                                { // Направо
                                    maze[y][x + 1] = pass;
                                    maze[y][x + 2] = pass;
                                    x += 2;
                                }
                            break;
                    }
                    if (deadend(x, y, maze, height, width))
                        break;
                }

                if (deadend(x, y, maze, height, width))
                    do
                    {
                        x = 2 * (rand.Next() % ((width - 1) / 2)) + 1;
                        y = 2 * (rand.Next() % ((height - 1) / 2)) + 1;
                    }
                    while (maze[y][x] != pass);
            }
        }
    }
}
