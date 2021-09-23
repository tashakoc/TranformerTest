using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTransformers
{
    class Fight
    {
        Mission misiions = new Mission();
        Autobots autobot = new Autobots();
        Decepticons decepticons = new Decepticons();
        User user = new User();
        Gun Gun = new Gun();
        TheTypeOfGun gun = new TheTypeOfGun();
        int CountOfShoot;
        Logger logger = new Logger();
        public List<Autobots> CreateAutobots()
        {
            List<Autobots> autobotsGroup = new List<Autobots>();
            autobot = User.UserChooseTheTypeOfTransformers();
            autobot.gun1 = User.ChooseTheTypeOfGun();
            autobotsGroup.Add(new Autobots());
            autobotsGroup.Add(new Autobots());
            autobotsGroup.Add(new Autobots());
            autobotsGroup.Add(new Autobots());
            foreach (var bot in autobotsGroup)
            {
                bot.TypeOfTransformer = autobot.TypeOfTransformer;
                bot.WayToFindTheEnemy = autobot.WayToFindTheEnemy;
                bot.livescore = autobot.livescore;
                bot.gun1 = autobot.gun1;
            }
            logger.LogFile.Add($"Создание групы из 4 Автоботов; Присваивание кадому автоботу следующих характеристик: вид: {autobot.TypeOfTransformer}, способ поиска врага:{autobot.WayToFindTheEnemy}" +
                $"Колличество жизней у каждого автобота {autobot.livescore}, вид оружия: {autobot.gun1} ");
            return autobotsGroup;
        }
        public List<Decepticons> CreateEnemy()
        {
             Random random = new Random();
            int choise = random.Next(1, 3);
            int choise2 = random.Next(1, 4);
            List<Decepticons> decepticonsGroup = new List<Decepticons>();
            decepticons = misiions.HardOfLevel(misiions);
            decepticons.CheckTypeOfAutobots(autobot,choise);
            decepticons.gun = decepticons.GetGun(autobot, choise2);
            switch (decepticons.countofgroup)
            {
                case 3:
                    decepticonsGroup.Add(new Decepticons());
                    decepticonsGroup.Add(new Decepticons());
                    decepticonsGroup.Add(new Decepticons());
                    break;
                case 5:
                    decepticonsGroup.Add(new Decepticons());
                    decepticonsGroup.Add(new Decepticons());
                    decepticonsGroup.Add(new Decepticons());
                    decepticonsGroup.Add(new Decepticons());
                    break;
                case 1:
                    decepticonsGroup.Add(new Decepticons());
                    break;
            }
            foreach (var decepticon in decepticonsGroup)
            {
                decepticon.gun = decepticons.gun;
                decepticon.livescore = decepticons.livescore;
                decepticon.TypeOfDecepticons = decepticons.TypeOfDecepticons;
                decepticon.countofgroup = decepticons.countofgroup;
            }
            logger.LogFile.Add($"Создание группы из {decepticons.countofgroup} Десептиконов. Присваивание каждому Десептикону следующих характеристик : оружие :{decepticons.gun}, колличество жизней у каждого десептикона: {decepticons.livescore}," +
                $"тип оружия : {decepticons.gun}, тип Десептиконов : {decepticons.TypeOfDecepticons} ");
            return decepticonsGroup;
        }

        public void Start()
        {
            logger.LogFile.Add("Запуск программы");
            logger.LogFile.Add("Выбор миссии пользователем");
            misiions.mission = User.Menu();
            logger.LogFile.Add($"Пользователь выбрал миссию : {misiions.mission} ");
            misiions.DescribeMission(misiions);
            logger.LogFile.Add($"Вывод на консоль описания миссии {misiions.mission}");
            List<Autobots> autobotsGroup = CreateAutobots();
            List<Decepticons> decepticons_group = CreateEnemy();
            MakeShoot(autobotsGroup, decepticons_group);
        }
        
        public void MakeShoot(List<Autobots> autobotsGroup, List<Decepticons> decepticons_group)
        {
            foreach (var autobot in autobotsGroup)
            {
                foreach (var decepticon in decepticons_group)
                {
                    while (autobot.livescore > 0 && decepticon.livescore > 0)
                    {
                        autobot.SearchingEnemy(autobot);
                        logger.LogFile.Add($"Поиск врага {autobot.WayToFindTheEnemy}");
                        Gun.damage = autobot.Shoot(true, autobot.gun1);
                        logger.LogFile.Add($"Враг был найден. Произведен выстрел из {autobot.gun1}. Врагу был нанесен урон: {Gun.damage} жизней");
                        decepticon.livescore = DamageCountingForDecepticons(autobot, Gun.damage);
                        logger.LogFile.Add($"У врага осталось {decepticon.livescore} жизней");
                        Gun.damage = decepticons.Shoot(decepticons);
                        logger.LogFile.Add($"Враг нанес удар с помощью {decepticon.gun}. Автоботам был нанесен урон : {Gun.damage} жизней.");
                       autobot.livescore = DamageCountingForAutobots(decepticon, Gun.damage);
                        logger.LogFile.Add($"У автоботов осталось {autobot.livescore} жизней");
                    }
                    if (decepticon.livescore <= 0)
                    {
                        Console.WriteLine("Враг Уничтожен!");
                        logger.LogFile.Add($"Враг был уничтожен.");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Победа за тобой!Миссия выполнена!");
                logger.LogFile.Add($"Пользователь победил. Миссия пройдена.");
                logger.SaveLogFile(logger.LogFile);
                break;
            }

        }
        public int DamageCountingForDecepticons(Autobots autobot, int damage)
        {
            gun = autobot.gun1;
            int damageofgun = damage;
            CountOfShoot++;
            if (CountOfShoot < 3)
            {
                decepticons.livescore -= damageofgun;
            }
            if (CountOfShoot == 3)
            {
                decepticons.livescore -= damageofgun * 4;
                CountOfShoot = 0;
            }
            return decepticons.livescore;

        }
        public int DamageCountingForAutobots(Decepticons decepticon, int damage)
        {
            decepticons.gun = decepticon.gun;
            int damageofgun = damage;
            CountOfShoot++;
            if (CountOfShoot < 3)
            {
                autobot.livescore -= damageofgun;
            }
            if (CountOfShoot == 3)
            {
                autobot.livescore -= damageofgun * 4;
                CountOfShoot = 0;
            }
            return autobot.livescore;

        }

    }
}
