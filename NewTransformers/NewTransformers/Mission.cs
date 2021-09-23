using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTransformers
{
   public enum Misiions
    {
        Убить_мятежников=1,
        Схватка_с_отрядом_врагов,
        Убить_Босса
    }
    public class Mission
    {
        Decepticons decepticons = new Decepticons();
       public Misiions mission;
       public Dictionary<string, int> CountOfLivesInEachMission = new Dictionary<string, int>();
        public void AddMission()
        {
            CountOfLivesInEachMission.Add("Убить_мятежников", 70);
            CountOfLivesInEachMission.Add("Схватка_с_отрядом_врагов", 100);
            CountOfLivesInEachMission.Add("Убить_Босса", 150);
        }
        public void DescribeMission(Mission newmission)
        {
            Console.Clear();
            if (newmission.mission == Misiions.Убить_мятежников)
            {
                Console.WriteLine("Описание миссии: \n" +
                    "Ранее,в мирное время, две рассы жили в мире, автоботы занимались наукой, а десептиконы защищали планету от возможных нападений.\n" +
                    "Но автоботы и десептиконы были слишком разными, и развязался конфликт за власть, переросший в Войну Трансформеров.\n" +
                    "В ходе войны автоботы открыли технологию трансформации, позволяющую им менять форму,искать врагов на суше, на земле и под водой при этом оставаясь не видимыми для врага.\n" +
                    "Дисептиконы профессиональные солдаты, поэтому легче сражаться с небольшими группами этих трансформеров\n" +
                    "Твоя задача найти и победить группу мятежников из 3 Десептиконов!");
            }
            if (newmission.mission == Misiions.Схватка_с_отрядом_врагов)
            {
                Console.WriteLine("Спасаясь от войны,опустошившей их родную планету, Кибертрон,Автобыты нашли убежище на планете Земля,которая стала большенству из них вторым домом.\n" +
                    "Десептиконы, жадущие все больше власти и территорий решили захватить Землю,тем самым получить полное господствование во вселенной\n" +
                    "Отряды Дисептиконов каждый день стали высаживаться на Землю и нападать на мирных граждан\n" +
                    "Твоя задача найти и победить группу мятяжников из 5 Десептиконов");
            }
            if (newmission.mission == Misiions.Убить_Босса)
            {
                Console.WriteLine("У десептиконов появился новый зловещий лидер — Мегатрон.\n" +
                    "Воспользовавшись беспечностью противника, он создал большую армию\n" +
                    "Мегатрон всегда был преисполнен ненависти к автоботам, он намеревается покончить с ними раз и навсегда.\n" +
                    "Для этого он планирует на Кибертроне всех павших десептиконов, превратив их в террорконов, а затем переправить полчища оживших робо-мертвецов на Землю.\n" +
                    "Не дай исполниться планам Мегатрона!Найди и уничтожь лидера Десептиконов!");
            }
           
        }
        public Decepticons HardOfLevel(Mission newmission)
        {
            
            if (newmission.mission == Misiions.Убить_мятежников)
            {
                decepticons.countofgroup = 3;
                decepticons.livescore = 25;
            }
            if (newmission.mission == Misiions.Схватка_с_отрядом_врагов)
            {
                decepticons.countofgroup = 5;
                decepticons.livescore = 30;
            }
            if (newmission.mission == Misiions.Убить_Босса)
            {
                decepticons.countofgroup = 1;
                decepticons.livescore = 100;
            }
            return decepticons;
            
        }
    }
}
