using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class Queue
    {
        public static void StartQueue()
        {
            Queue<string> numbers = new Queue<string>();
            int count = 0;
        start:
            while (bookthequeue(numbers, ref count) == "да")
                bookthequeue(numbers, ref count);
            if (count >= 5)
            {
                deletefromqueue(numbers, ref count);
            }
            else
            {
                Console.WriteLine("В очереди менее 5 человек, ОЖИДАЙТЕ!!!");
                bookthequeue(numbers, ref count);
            }
            goto start;
        }
        static public string bookthequeue(Queue<string> numbers, ref int count)
        {
            Console.WriteLine("Хотите записаться в очередь к доктору?");
            string answer = Console.ReadLine().ToLower();
            if (answer.Equals("да"))
            {
                Console.WriteLine("Укажите ваше имя");
                string name = Console.ReadLine();
                numbers.Enqueue(name);
                count++;
            }
            else
                deletefromqueue(numbers, ref count);
            return answer;
        }
        static public void deletefromqueue(Queue<string> numbers, ref int count)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Count; i++)
            {
                string queueElement = numbers.Dequeue();
                Console.WriteLine($"{queueElement}, Вы на приеме у врача!");
                int time = random.Next(5000, 15000);
                Thread.Sleep(time);
                Console.WriteLine("Время ожидания " + time + " мс");
                count--;
            }
        }   }
}
