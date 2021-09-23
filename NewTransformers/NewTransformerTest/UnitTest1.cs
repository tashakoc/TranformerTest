using NUnit.Framework;
using NewTransformers;
using System;
using System.Collections.Generic;

namespace NewTransformerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase(Misiions.Убить_мятежников,3, 25)]
        [TestCase(Misiions.Схватка_с_отрядом_врагов, 5,30)]
        [TestCase(Misiions.Убить_Босса, 1, 100)]
        public void CheckHardOfLevel(Misiions misiions, int countofgroup,int livescore)
        {
            Mission newmission = new Mission();
            newmission.mission = misiions;
            Mission mission = new Mission();
            Decepticons actual = mission.HardOfLevel(newmission);
            Assert.AreEqual(countofgroup, actual.countofgroup);
            Assert.AreEqual(livescore, actual.livescore);
        }
        [TestCase(TypeOfTransformers.Водные, 1, TypeOfTransformers.Воздушные)]
        [TestCase(TypeOfTransformers.Водные, 2, TypeOfTransformers.Наземные)]
        [TestCase(TypeOfTransformers.Воздушные, 1, TypeOfTransformers.Водные)]
        [TestCase(TypeOfTransformers.Воздушные, 2, TypeOfTransformers.Наземные)]
        [TestCase(TypeOfTransformers.Наземные, 1, TypeOfTransformers.Воздушные)]
        [TestCase(TypeOfTransformers.Наземные, 2, TypeOfTransformers.Водные)]
        public void CheckCorrectTypeOfDecepticons(TypeOfTransformers Typeofautobots , int choises ,TypeOfTransformers typeOfdecepticons)
        {

            Decepticons actual = new Decepticons();
            Autobots autobots = new Autobots();
            int choise = choises;
            autobots.TypeOfTransformer = Typeofautobots;
            actual.TypeOfDecepticons = actual.CheckTypeOfAutobots(autobots,choise);
            Assert.AreEqual(typeOfdecepticons, actual.TypeOfDecepticons);
        }
        [TestCase(TheTypeOfGun.Базука, 1, TheTypeOfGun.Гранатомет)]
        [TestCase(TheTypeOfGun.Базука, 2, TheTypeOfGun.Меч)]
        [TestCase(TheTypeOfGun.Базука, 3, TheTypeOfGun.Огнемёт)]
        [TestCase(TheTypeOfGun.Гранатомет, 1, TheTypeOfGun.Базука)]
        [TestCase(TheTypeOfGun.Гранатомет, 2, TheTypeOfGun.Меч)]
        [TestCase(TheTypeOfGun.Гранатомет, 3, TheTypeOfGun.Огнемёт)]
        [TestCase(TheTypeOfGun.Меч, 1, TheTypeOfGun.Гранатомет)]
        [TestCase(TheTypeOfGun.Меч, 2, TheTypeOfGun.Базука)]
        [TestCase(TheTypeOfGun.Меч, 3, TheTypeOfGun.Огнемёт)]
        [TestCase(TheTypeOfGun.Огнемёт, 1, TheTypeOfGun.Гранатомет)]
        [TestCase(TheTypeOfGun.Огнемёт, 2, TheTypeOfGun.Меч)]
        [TestCase(TheTypeOfGun.Огнемёт, 3, TheTypeOfGun.Базука)]
        public void CheckCorrectTypeOfGunofDecepticons(TheTypeOfGun autobotgun, int choises, TheTypeOfGun typeOfgun)
        {

            Decepticons actual = new Decepticons();
            Autobots autobot = new Autobots();
            int choise = choises;
            autobot.gun1 = autobotgun;
            actual.gun = actual.GetGun(autobot, choise);
            Assert.AreEqual(typeOfgun, actual.gun);
        }
        [TestCase(TheTypeOfGun.Базука, 5)]
        [TestCase(TheTypeOfGun.Гранатомет, 10)]
        [TestCase(TheTypeOfGun.Меч, 20)]
        [TestCase(TheTypeOfGun.Огнемёт, 15)]
        public void CheckCorrectGunDamage(TheTypeOfGun gun, int damage)
        {
            Decepticons decepticons = new Decepticons();
            decepticons.gun = gun;
            int actual = decepticons.Shoot(decepticons);
            Assert.AreEqual(damage, actual);
        }
     
        public void CheckArrayIsNotEmpty()
        {
            Dictionary<string, int> GunDamage = new Dictionary<string, int>();
            Gun gun = new Gun();
            GunDamage=gun.AddDamageOfGun();
            Assert.IsNotEmpty(GunDamage);

        }

    }
}