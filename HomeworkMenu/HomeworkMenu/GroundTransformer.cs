using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformers
{
    class GroundTransformer:AllTransformersIS
    {
        public void ChoiseOfCondition()
        {
            Console.WriteLine("Выбери в кого мне трансформироваться : \nВ Гуманоида -->1\nВ Транспорт-->2");
            int condition = int.Parse(Console.ReadLine());
            switch (condition)
            {
                case 1:
                    Humanoid conditionhumanoid = new Humanoid();
                    conditionhumanoid.Movement();
                    break;
                case 2:
                    Transport conditiontransport = new Transport();
                    conditiontransport.Movement();
                    break;
            }
        }
        public void SearchForTheEnemy()
        {
            Console.WriteLine("ищу врагов с помощью оптического сканера");
        }
    }
}
