
using System;

namespace Transformers
{
    public static class Trans
    {
        public static void Transformers()
        {
            AirTransformer OptimusPrime = new AirTransformer();
            GroundTransformer Bumblebee = new GroundTransformer();
            WaterTransformer Megatron = new WaterTransformer();
            bool isbacktomenu = true;
            while (isbacktomenu)
            {
                Console.WriteLine("Выбери своего трансформера : \nВоздушный трансформер Оптимус Прайм -->1\nНаземный трансформер Бамблби-->2\nВодяной трансформер Мегатрон-->3");
                int typeoftransformer = int.Parse(Console.ReadLine());
                switch (typeoftransformer)
                {
                    case 1:
                        Console.WriteLine("Привет,землянин, меня зовут Оптимус Прайм");
                        OptimusPrime.ChoiseOfCondition();
                        OptimusPrime.SearchForTheEnemy();
                        break;
                    case 2:
                        Console.WriteLine("Привет,землянин, меня зовут Бамблби");
                        Bumblebee.ChoiseOfCondition();
                        Bumblebee.SearchForTheEnemy();
                        break;
                    case 3:
                        Console.WriteLine("Привет,землянин, меня зовут Мегатрон");
                        Megatron.ChoiseOfCondition();
                        Megatron.SearchForTheEnemy();
                        break;
                }                
                Console.WriteLine("Вернуться в главное меню-->1\nВыйти из программы-->0");
                int answer = int.Parse(Console.ReadLine());
                Console.Clear();
                if (answer == 1)
                {
                    isbacktomenu = true;
                }
                else
                {
                    isbacktomenu = false;
                    Console.WriteLine("У всех разумных существ есть право быть свободными!До скорых встреч,землянин!!!");
                }

            }
            

        }

    }
    public interface AllTransformersIS
    {
        void SearchForTheEnemy();
        public void ChoiseOfCondition();

    }
    public interface HumanoidOrTransportDo
    {
        public void Movement();
    }
}
