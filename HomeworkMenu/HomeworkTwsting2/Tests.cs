using NUnit.Framework;
using HomeworkMenu;



namespace HomeworkTwsting2
{
    public class Tests
    {

        [Test]
        [TestCase(new string[] { "Иван", "Наталия", "Сергей", "Виталий", "Татьяна", "John", "Olha", "Valeriy", "Anastasiya", "Veronika" },"Nikolay",0, new string[] { "Nikolay", "Иван", "Наталия", "Сергей", "Виталий", "Татьяна", "John", "Olha", "Valeriy", "Anastasiya", "Veronika" })]
        public void CheckCorrectArrayChangingAfterAddingName(string[] array, string name, int index, string[] newarray)
        {
            string[] actual = Homework4.Addname(array, name, index);
            Assert.AreEqual(newarray, actual);
        }
        [TestCase(new string[] { "Иван", "Наталия", "Сергей", "Виталий", "Татьяна", "John", "Olha", "Valeriy", "Anastasiya", "Veronika" }, "Olha", 0, new string[] { "Иван", "Наталия", "Сергей", "Виталий", "Татьяна", "John", "Valeriy", "Anastasiya", "Veronika" })]
        public void CheckCorrectArrayChangingAfterDeleteName(string[] array, string name, int index, string[] newarray)
        {
            string[] actual = Homework4.Removename(array, name, index);
            Assert.AreEqual(newarray, actual);
        }
    }
}