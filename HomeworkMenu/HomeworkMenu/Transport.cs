using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformers
{
    class Transport:HumanoidOrTransportDo
    {
        public  void Movement()
        {
            Console.WriteLine("Я могу плавать, летать и ездить!");
            Console.WriteLine("Выбери одно из того,что я могу сделать: \nПлыть-->1\nЛететь-->2\nЕхать-->3");
            int choiseofmovement = int.Parse(Console.ReadLine());
            switch (choiseofmovement)
            {
                case 1:
                    Console.Write("Я плыву и ");
                    break;
                case 2:
                    Console.Write("Я лечу и ");
                    break;
                case 3:
                    Console.Write("Я еду и ");
                    break;
                default:
                    break;

            }

        }
      
    }
}
