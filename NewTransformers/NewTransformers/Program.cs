using System;

namespace NewTransformers
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Start:
            Fight fight = new Fight();
            fight.Start();
            
            Console.WriteLine("Вернуться в главное меню==> 1\n"  +
                "Выйти ==> 2\n" +
                "Посмотреть лог предыдущей игры ==> 3");
            string choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                    goto Start;
                case "2":
                    Console.WriteLine("У всех разумных существ есть право быть свободными.До скорых встреч,Землянин!");
                    break;
                case "3":
                    logger.ReadLogFile();
                    break;
            }

        }
    }
}
