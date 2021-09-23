using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMenu
{
    class Homework5
    {
       static public void MakeChoice()
        {
            Console.WriteLine("Выберите задание:\nПрограмма для регистрации и авторизации--->1\nОчередь--->2\nТелефонная Книга--->3");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    ProgrammToRegistrated.MakeDessision();
                    break;
                case 2:
                    Queue.StartQueue();
                    break;
                case 3:
                    PB.StartPhonebook();
                    break;
            }

        }
    }
}
