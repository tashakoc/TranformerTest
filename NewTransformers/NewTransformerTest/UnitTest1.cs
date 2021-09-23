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
        [TestCase(Misiions.�����_����������,3, 25)]
        [TestCase(Misiions.�������_�_�������_������, 5,30)]
        [TestCase(Misiions.�����_�����, 1, 100)]
        public void CheckHardOfLevel(Misiions misiions, int countofgroup,int livescore)
        {
            Mission newmission = new Mission();
            newmission.mission = misiions;
            Mission mission = new Mission();
            Decepticons actual = mission.HardOfLevel(newmission);
            Assert.AreEqual(countofgroup, actual.countofgroup);
            Assert.AreEqual(livescore, actual.livescore);
        }
        [TestCase(TypeOfTransformers.������, 1, TypeOfTransformers.���������)]
        [TestCase(TypeOfTransformers.������, 2, TypeOfTransformers.��������)]
        [TestCase(TypeOfTransformers.���������, 1, TypeOfTransformers.������)]
        [TestCase(TypeOfTransformers.���������, 2, TypeOfTransformers.��������)]
        [TestCase(TypeOfTransformers.��������, 1, TypeOfTransformers.���������)]
        [TestCase(TypeOfTransformers.��������, 2, TypeOfTransformers.������)]
        public void CheckCorrectTypeOfDecepticons(TypeOfTransformers Typeofautobots , int choises ,TypeOfTransformers typeOfdecepticons)
        {

            Decepticons actual = new Decepticons();
            Autobots autobots = new Autobots();
            int choise = choises;
            autobots.TypeOfTransformer = Typeofautobots;
            actual.TypeOfDecepticons = actual.CheckTypeOfAutobots(autobots,choise);
            Assert.AreEqual(typeOfdecepticons, actual.TypeOfDecepticons);
        }
        [TestCase(TheTypeOfGun.������, 1, TheTypeOfGun.����������)]
        [TestCase(TheTypeOfGun.������, 2, TheTypeOfGun.���)]
        [TestCase(TheTypeOfGun.������, 3, TheTypeOfGun.������)]
        [TestCase(TheTypeOfGun.����������, 1, TheTypeOfGun.������)]
        [TestCase(TheTypeOfGun.����������, 2, TheTypeOfGun.���)]
        [TestCase(TheTypeOfGun.����������, 3, TheTypeOfGun.������)]
        [TestCase(TheTypeOfGun.���, 1, TheTypeOfGun.����������)]
        [TestCase(TheTypeOfGun.���, 2, TheTypeOfGun.������)]
        [TestCase(TheTypeOfGun.���, 3, TheTypeOfGun.������)]
        [TestCase(TheTypeOfGun.������, 1, TheTypeOfGun.����������)]
        [TestCase(TheTypeOfGun.������, 2, TheTypeOfGun.���)]
        [TestCase(TheTypeOfGun.������, 3, TheTypeOfGun.������)]
        public void CheckCorrectTypeOfGunofDecepticons(TheTypeOfGun autobotgun, int choises, TheTypeOfGun typeOfgun)
        {

            Decepticons actual = new Decepticons();
            Autobots autobot = new Autobots();
            int choise = choises;
            autobot.gun1 = autobotgun;
            actual.gun = actual.GetGun(autobot, choise);
            Assert.AreEqual(typeOfgun, actual.gun);
        }
        [TestCase(TheTypeOfGun.������, 5)]
        [TestCase(TheTypeOfGun.����������, 10)]
        [TestCase(TheTypeOfGun.���, 20)]
        [TestCase(TheTypeOfGun.������, 15)]
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