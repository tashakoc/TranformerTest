using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTransformers
{
    public enum TheTypeOfGun
    {
        Меч = 1,
        Гранатомет,
        Базука,
        Огнемёт
    }
   public class Gun
    {
        public TheTypeOfGun TypeOfGun;
        public Dictionary<string, int> GunDamage = new Dictionary<string, int>();
        public int damage;
        public Dictionary<string, int> AddDamageOfGun()
        {
            GunDamage.Add("Меч", 20);
            GunDamage.Add("Гранатомет", 10);
            GunDamage.Add("Базука", 5);
            GunDamage.Add("Огнемёт", 15);
            return GunDamage;
        }

    }
}
