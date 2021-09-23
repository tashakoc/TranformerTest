using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewTransformers
{ 
    public enum TypeOfTransformers
    {
        Водные = 1,
        Наземные,
        Воздушные
    }
    public class Autobots
    {
        public TypeOfTransformers TypeOfTransformer;
        public TheTypeOfGun gun1 = new TheTypeOfGun();
        public string WayToFindTheEnemy;
        bool IsEnemyFounded;
        bool IsHummanoid;
        public int livescore = 100;
      
       public  void SearchingEnemy(Autobots user_choise_of_transformers)
        {
            int time;
            if(user_choise_of_transformers.TypeOfTransformer == TypeOfTransformers.Водные)
            {
                IsEnemyFounded = false;
                time = 7000;
                Console.WriteLine($"Ищу врага {user_choise_of_transformers.WayToFindTheEnemy}");
                Thread.Sleep(time);
                Console.WriteLine("Враг найден");
                IsEnemyFounded = true;
            }
            if(user_choise_of_transformers.TypeOfTransformer == TypeOfTransformers.Воздушные)
            {
                IsEnemyFounded = false;
                time = 3000;
                Console.WriteLine($"Ищу врага {user_choise_of_transformers.WayToFindTheEnemy} ");
                Thread.Sleep(time);
                Console.WriteLine("Враг найден");
                IsEnemyFounded = true;
            }
            if (user_choise_of_transformers.TypeOfTransformer == TypeOfTransformers.Наземные)
            {
                IsEnemyFounded = false;
                time = 5000;
                Console.WriteLine($"Ищу врага {user_choise_of_transformers.WayToFindTheEnemy} ");
                Thread.Sleep(time);
                Console.WriteLine("Враг найден");
                IsEnemyFounded = true;
            }
            //return IsEnemyFounded;
        }
      
        public int Shoot(bool IsEnemyFounded, TheTypeOfGun user_choise_of_gun)
        {
            Gun gun = new Gun();
            gun.AddDamageOfGun();
            if (IsEnemyFounded)
            {
                foreach(KeyValuePair<string, int> keyValue in gun.GunDamage)
                {
                    if(keyValue.Key.Contains(user_choise_of_gun.ToString()))
                    {
                        Console.WriteLine($"Мое оружие это {keyValue.Key}.Используюю его для уничтожения врага!");
                        gun.damage = keyValue.Value;
                    }
                }
            }
            return gun.damage;
        }
    }

}
