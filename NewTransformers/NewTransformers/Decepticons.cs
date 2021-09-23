using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTransformers
{
   public class Decepticons
    {
        public int countofgroup;
        public int livescore;
        public TheTypeOfGun gun;
        public TypeOfTransformers TypeOfDecepticons;
        public TypeOfTransformers CheckTypeOfAutobots(Autobots autobots,int choise)
        {
            switch (autobots.TypeOfTransformer)
            {
                case TypeOfTransformers.Водные:
                    if (choise == 1)
                    {
                        TypeOfDecepticons = TypeOfTransformers.Воздушные;
                    }
                    if (choise == 2)
                    {
                        TypeOfDecepticons = TypeOfTransformers.Наземные;
                    }
                    break;
                case TypeOfTransformers.Воздушные:
                    if (choise == 1)
                    {
                        TypeOfDecepticons = TypeOfTransformers.Водные;
                    }
                    if (choise == 2)
                    {
                        TypeOfDecepticons = TypeOfTransformers.Наземные;
                    }
                    break;
                case TypeOfTransformers.Наземные:
                    if (choise == 1)
                    {
                        TypeOfDecepticons = TypeOfTransformers.Воздушные;
                    }
                    if (choise == 2)
                    {
                        TypeOfDecepticons = TypeOfTransformers.Водные;
                    }
                    break;
            }
            return TypeOfDecepticons;

        }
        public TheTypeOfGun GetGun(Autobots autobots,int choise)
        {
            switch (autobots.gun1)
            {
                case TheTypeOfGun.Базука:
                    if (choise == 1)
                    {
                        gun = TheTypeOfGun.Гранатомет;
                    }
                    if (choise == 2)
                    {
                        gun = TheTypeOfGun.Меч;
                    }
                    if (choise == 3)
                    {
                        gun = TheTypeOfGun.Огнемёт;
                    }
                    break;
                case TheTypeOfGun.Гранатомет:
                    if (choise == 1)
                    {
                        gun = TheTypeOfGun.Базука;
                    }
                    if (choise == 2)
                    {
                        gun = TheTypeOfGun.Меч;
                    }
                    if (choise == 3)
                    {
                        gun = TheTypeOfGun.Огнемёт;
                    }
                    break;
                case TheTypeOfGun.Меч:
                    if (choise == 1)
                    {
                        gun = TheTypeOfGun.Гранатомет;
                    }
                    if (choise == 2)
                    {
                        gun = TheTypeOfGun.Базука;
                    }
                    if (choise == 3)
                    {
                        gun = TheTypeOfGun.Огнемёт;
                    }
                    break;
                case TheTypeOfGun.Огнемёт:
                    if (choise == 1)
                    {
                        gun = TheTypeOfGun.Гранатомет;
                    }
                    if (choise == 2)
                    {
                        gun = TheTypeOfGun.Меч;
                    }
                    if (choise == 3)
                    {
                        gun = TheTypeOfGun.Базука;
                    }
                    break;
            }
            return gun;
        }
        public int Shoot(Decepticons decepticons)
        {
            Gun gun = new Gun();
            gun.AddDamageOfGun();
                foreach (KeyValuePair<string, int> keyValue in gun.GunDamage)
                {
                    if (keyValue.Key.Contains(decepticons.gun.ToString()))
                    {
                        gun.damage = keyValue.Value;
                    }
                }
            return gun.damage;
        }
    }
}
