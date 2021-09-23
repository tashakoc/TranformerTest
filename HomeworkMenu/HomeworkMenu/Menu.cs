using System;

namespace HomeworkMenu
{
    class Menu
    {
        static void Main(string[] args)
        {
            MainMenu();
            
        }
        static public void MainMenu()
        {
            FileSaver filesaver = new FileSaver();
            Console.WriteLine("Выберите какое домашнее задание вы хотите посмотреть");
            Console.WriteLine("Домашнее задание до курсов - 0\n" +
                "Homework1 - 1\n" +
                "Homework2 - 2\n" +
                "Homework3 - 3\n" +
                "Homework4 - 4\n" +
                "Homework5 - 5\n" +
                "RSPGame - 6\n" +
                "Transformers - 7\n" +
                "Библиотека - 8\n" +
                "Cохранить текст как файл формата: txt,csv,pdf - 9\n" +
                "Магазин продуктов - 10\n" +
                "Конвертер валют - 11");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 0)
                HW1_beforecourses();
            if (answer == 1)
                HW1();
            if (answer == 2)
                HM2();
            if (answer == 3)
                HW3();
            if (answer == 4)
                HW4();
            if (answer == 5)
                Homework5.MakeChoice();
            if (answer == 6)
                RSPGame.StartGame();
            if (answer == 7)
                Transformers.Trans.Transformers();
            if (answer == 8)
                MyLibrary.Program.StartLib();
            if (answer == 9)
                FileSaverMenu.StartFileSavingProgram(filesaver);
            if (answer == 10)
                MenuOfStore.Menu();
            if (answer == 11)
                Converter.GetInfo();
           
            

        }


        static public void HW4()
        {
            Console.WriteLine("Простой но надежный калькулятор----->1\n\n" +
                "Книга имен,с возможностью удалять,добавлять имена и просматривать всю книгу----->2\n\n" +
                "Расчитать периметр,радиус и площадь круга----->3\n\n" +
                "Метод вывода фигур из ноликов----->4\n\n");
            Console.WriteLine("Выберите какое домашнее задание вы хотите посмотреть");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
                Homework4.Calculator();
            else if (answer == 2)
                Homework4.NameBook();
            else if (answer == 3)
                Homework4.perimetr_area_radius();
            else if (answer == 4)
                Homework4.PrintFigure();
            if (IsFinished())
            {
                Console.Clear();
                MainMenu();
            }
        }
        static public void HW3()
        {
            Console.WriteLine("Выводить все элементы массива пока не встретится элемент с не положительным значением----->1\n\n" +
                "добавить элемент в конец или начало массива----->2\n" +
                "суммa всех чисел двумерного массива----->3\n" +
                "Вывести двумерный массив в консоль, чтобы элементы располагались в виде матрицы----->4\n\n" +
                "двумерный массив в консоль, чтобы элементы располагались в виде матрицы, негативные цифры не должны выводиться----->5\n\n" +
                "сколько слов, которые начинаются с заглавной буквы находятся в предложении----->6\n" +
                "выводится максимальная, минимальная, средняя зп и общая сумма----->7\n" +
                "ввести сколько угодно данных в таблицу/Если он напишет stop, то программа выведет ему все данные----->8\n\n" +
                "Создать двумерный массив 5х5.Заполнить случайными значениями от 0 до 20.НЕ показывать пользователю. Спрашивать по одному числу----->9\n\n" +
                "Убрать лишнее из строки----->10\n\n" +
                "Заполнить массив из 20 елементов числами Фибоначии и вывести их на экран----->11\n\n" +
                "Заполнить случайными значениями от 0 до 20.НЕ показывать пользователю. Спрашивать по одному числу со звездочкой----->12\n\n" +
                "Лабиринт----->13\n");
            Console.WriteLine("Выберите какое домашнее задание вы хотите посмотреть");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
                Homework3.PrintPosiveArrayNum();
            else if (answer == 2)
                Homework3.AddElementToArray();
            else if (answer == 3)
                Homework3.SumOFArray();
            else if (answer == 4)
                Homework3.PrintMatrix();
            else if (answer == 5)
                Homework3.PrintMatrixWithoutNegativeNum();
            else if (answer == 6)
                Homework3.FindUpperWord();
            else if (answer == 7)
                Homework3.CalculationOfSalary();
            else if (answer == 8)
                Homework3.PrintTableOfData();
            else if (answer == 9)
                Homework3.GuessTheNum();
            else if (answer == 10)
                Homework3.ChangeArray();
            else if (answer == 11)
                Homework3.Fibbonachi();
            else if (answer == 12)
                Homework3.GuessTheNumHard();
            else if (answer == 13)
                Homework3.Maze();
            if (IsFinished())
            {
                Console.Clear();
                MainMenu();
            }


        }
        static public void HM2()
        {
            Console.WriteLine("Вводим дату словами,выводится дата цифрами в указанном формате----->1\n\n" +
                "простой калькулятор----->2\n" +
                "удалить из строки лишние пробелы, изменить имя Гриша на Григорий, и номер заказа ‘#123123’ удалить вместе с ненужными пробелами----->3\n\n" +
                "Найти кол-во дубликатов Я в предложении и вывести их кол-во----->4\n\n" +
                "Вывести на консоль те строки, длина которых меньше средней и также содержит в себе слово палиндром----->5\n\n" +
                "Удалить все записи на транслите, выделить каждое имя собственное как обращение и все большие буквы в середине слова заменить на маленькие----->6\n");
            Console.WriteLine("Выберите какое домашнее задание вы хотите посмотреть");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
                Homework2.PrintDate();
            else if (answer == 2)
                Homework2.SimpleCalculator();
            else if (answer == 3)
                Homework2.HelloGrisha();
            else if (answer == 4)
                Homework2.FindDuplicate();
            else if (answer == 5)
                Homework2.FindPalindrom();
            else if (answer == 6)
                Homework2.ChangeString();
            if (IsFinished())
            {
                Console.Clear();
                MainMenu();
            }
        }
        static public void HW1()
        {
            Console.WriteLine("справшивает какая погода на улице----->1\n\n" +
                "выводит к какому веку относится год----->2\n\n" +
                "выводит наибольшее из чисел----->3\n\n" +
                "Выводит на экран частное 2 чисел----->4\n\n" +
                "Считает скидку----->5\n");
            Console.WriteLine("Выберите какое домашнее задание вы хотите посмотреть");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
                Homework1.GiveThetemperature();
            else if (answer == 2)
                Homework1.GetCentury();
            else if (answer == 3)
                Homework1.MaxNum();
            else if (answer == 4)
                Homework1.Devide2num();
            else if (answer == 5)
                Homework1.GetDiscount();
            if (IsFinished())
            {
                Console.Clear();
                MainMenu();
            }

        }
        static public void HW1_beforecourses()
        {
            Console.WriteLine("Выбeрите раздел : \n" +
                "Условные операторы - 1\nЦиклы - 2\nМассивы - 3\nМетоды - 4");
            int answeer = int.Parse(Console.ReadLine());
            if (answeer == 1)
                if_elses();
            else if (answeer == 2)
                cicles();
            else if (answeer == 3)
                Arrays();
            else if (answeer == 4)
                Functions();

        }
        static public void if_elses()
        {
            Console.WriteLine("Если а – четное посчитать а*б, иначе а+б----->1\n\n" +
                "Определить какой четверти принадлежит точка с координатами (х,у)----->2\n\n" +
                "Найти суммы только положительных из трех чисел----->3\n\n" +
                "Посчитать выражение (макс(а*б*с, а+б+с))+3----->4\n" +
                "Написать программу определения оценки студента по его рейтингу----->5\n");
            Console.WriteLine("Выберите какое домашнее задание вы хотите посмотреть");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
                Homework1_before_courses.if_else_1();
            else if (answer == 2)
                Homework1_before_courses.if_else_2();
            else if (answer == 3)
                Homework1_before_courses.if_else_3();
            else if (answer == 4)
                Homework1_before_courses.if_else_4();
            else if (answer == 5)
                Homework1_before_courses.if_else_5();

        }
        static public void cicles()
        {
            Console.WriteLine("Найти сумму четных чисел и их количество в диапазоне от 1 до 99----->1\n\n" +
                "Проверить простое ли число?----->2\n\n" +
                "Найти корень----->3\n\n" +
                "факториал числа----->4\n\n" +
                "Посчитать сумму цифр заданного числа----->5\n\n" +
                "Вывести число, которое является зеркальным отображением последовательности цифр заданного числа----->6\n");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
                Homework1_before_courses.cicle_1();
            else if (answer == 2)
                Homework1_before_courses.cicle_2();
            else if (answer == 3)
            {
                Console.WriteLine("Введите 1 если если хотете воспользоваться бинарным подбором и 0 если линейным поиском");
                int answer2 = int.Parse(Console.ReadLine());
                Console.Clear();
                if (answer2 == 1)
                    Homework1_before_courses.Cicle_3_binary();
                else if (answer2 == 0)
                    Homework1_before_courses.cicle_3_line();
            }
            else if (answer == 4)
                Homework1_before_courses.Cicle_4();
            else if (answer == 5)
                Homework1_before_courses.Cicle_5();
            else if (answer == 6)
                Homework1_before_courses.Cicle_6();

        }
        static public void Arrays()
        {
            Console.WriteLine("Найти_индекс_min_max_элемента_массива--1\n\n" +
                "количество_нечетных_элементов_массива----->2\n\n" +
                "Найти минимальный элемент массива_Найти максимальный элемент массива----->3\n\n" +
                "Поменять_местами_первую_и_вторую_половину_массива----->4\n\n" +
                "Сделать реверс массива----->5\n\n" +
                "Cумма элементов массива с нечетными индексами----->6\n\n" +
                "Отсортировать_массив----->7\n\n");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
                Homework1_before_courses.Array_1();
            else if (answer == 2)
                Homework1_before_courses.Array_2();
            else if (answer == 3)
                Homework1_before_courses.Array_3();
            else if (answer == 4)
                Homework1_before_courses.Array_4();
            else if (answer == 5)
                Homework1_before_courses.Array_5();
            else if (answer == 6)
                Homework1_before_courses.Array_6();
            else if (answer == 7)
                Console.WriteLine("Методом пузырька----->1\n" +
                    "Выбором----->2\n" +
                    "Вставками----->3");
            int answer2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer2 == 1)
                Homework1_before_courses.Array_7_bubble();
            else if (answer2 == 2)
                Homework1_before_courses.Array_7_Select();
            else if (answer2 == 3)
                Homework1_before_courses.Array_7_Insert();
        }
        static public void Functions()
        {
            Console.WriteLine("Вводим строку.Получить само число----->1\n\n" +
                "одим число(0-999), получаем строку с прописью числа----->2\n\n" +
                "Найти_расстояние_между_двумя_точками----->3\n\n" +
                "строковое название дня недели по номеру дня----->4\n");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
                Homework1_before_courses.Function_1();
            else if (answer == 2)
                Homework1_before_courses.Function_2();
            else if (answer == 3)
                Homework1_before_courses.Function_3();
            else if (answer == 4)
                Homework1_before_courses.Function_4();


        }
        static public bool IsFinished()
        {
            Console.WriteLine("Нажмите 1 для того чтобы вернуться в главное меню ");
            int finish = int.Parse(Console.ReadLine());
            if (finish == 1)
                return true;
            else
                return false;
        }
        
    }
}
