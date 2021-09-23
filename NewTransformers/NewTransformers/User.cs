using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTransformers
{
    public class User
    {
        
        static Fight fight = new Fight();
        public static Misiions Menu()
        {
            Mission newmission = new Mission();
            newmission.AddMission();
            Console.WriteLine("Привет,Землянин,выбери миссию,которую ты хочешь выполнить\n" +
                "Убить мятежников ==> 1\n" +
                "Схватка с отрядом врагов ==> 2\n" +
                "Убить Босса ==> 3");//fight
            Misiions ChoiseOfMission = (Misiions)Enum.Parse(typeof(Misiions), Console.ReadLine());
            newmission.mission = ChooseTheMission(newmission, ChoiseOfMission);
            return newmission.mission;

        }
        public static Misiions ChooseTheMission(Mission newmission, Misiions ChoiseOfMission)
        {
           
            foreach (var mission in newmission.CountOfLivesInEachMission)
            {
                if (mission.Key.Contains(ChoiseOfMission.ToString()))
                {
                    newmission.mission = ChoiseOfMission;

                }
            }
            return newmission.mission;
        }
        public static Autobots UserChooseTheTypeOfTransformers()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Выбери вид трансформеров,с которыми ты бы хотел пройти эту миссию?\n" +
                "Водные ==> 1\n" +
                "Наземные ==> 2\n" +
                "Воздушные ==> 3");
            TypeOfTransformers user_choise_of_transformers = (TypeOfTransformers)Enum.Parse(typeof(TypeOfTransformers), Console.ReadLine());
            Autobots new_transformer = new Autobots();
            new_transformer.TypeOfTransformer = user_choise_of_transformers;
            switch (user_choise_of_transformers)
            {
                case TypeOfTransformers.Водные:
                    new_transformer.WayToFindTheEnemy = "с помощью эхолокатора";
                    return new_transformer;
                case TypeOfTransformers.Воздушные:
                    new_transformer.WayToFindTheEnemy = "с помощью сканера [свой - чужой]";
                    return new_transformer;
                case TypeOfTransformers.Наземные:
                    new_transformer.WayToFindTheEnemy = "с помощью оптического сканера";
                    return new_transformer;
            }
            ChooseTheTypeOfGun();
            return new_transformer;
            
        }
        public static TheTypeOfGun ChooseTheTypeOfGun()
        {
            Console.WriteLine("Выбери вид оружия для твоих трансформеров\n" +
                "Меч ==> 1\n" +
                "Гранатомет ==> 2\n" +
                "Базука ==> 3\n" +
                "Огнемёт ==> 4");
            TheTypeOfGun user_choise_of_gun = (TheTypeOfGun)Enum.Parse(typeof(TheTypeOfGun), Console.ReadLine());
            return user_choise_of_gun;
            
        }
        

    }
}
