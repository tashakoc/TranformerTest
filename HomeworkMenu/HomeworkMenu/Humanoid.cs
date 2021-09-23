using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformers
{
   public class Humanoid:HumanoidOrTransportDo
    {
       public void Movement()
        {
            Console.WriteLine("Я могу стрелять и бегать!");
            Console.WriteLine("Выбери одно из того,что я могу сделать: \nСтрелять-->1\nБежать-->2");
            int choiseofmovement = int.Parse(Console.ReadLine());
            switch (choiseofmovement)
            {
                case 1:
                  Shooting();
                    break;
                case 2:
                    Console.Write("Я бегу и ");
                    break;
                default:
                    break;

            }

        }
        public static void Shooting()
        {
            Console.WriteLine("Я могу стрелять из: \nПулемета-->1\nОгнемета-->2\nГравитационной пушки-->3\nПортальной пушки-->4\nБазуки-->5");
            Console.WriteLine("Выбери оружие по номеру!");
            int choiseofshoot = int.Parse(Console.ReadLine());
            switch (choiseofshoot)
            {
                case 1:
                    Console.Write("Я стреляю из пулемета и");
                    break;
                case 2:
                    Console.Write("Я стреляю из огнемета и ");
                    break;
                case 3:
                    Console.Write("Я стреляю из гравитационной пушки и ");
                    break;
                case 4:
                    Console.Write("Я стреляю из портальной пушки и ");
                    break;
                case 5:
                    Console.Write("Я стреляю из базуки и ");
                    break;
            }
        }

    }
}
