using System;
using Xunit;
using HomeworkMenu;

namespace HomeWorkMenuTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-21, "Я не верю что такая погода может быть!")]
        [InlineData(-20, "Сейчас холодно")]
        [InlineData(5, "Сейчас холодно")]
        [InlineData(6, "Сейчас прохладно")]
        [InlineData(15, "Сейчас прохладно")]
        [InlineData(16, "Сейчас тепло")]
        [InlineData(20, "Сейчас тепло")]
        [InlineData(21, "Сейчас жарко")]
        [InlineData(35, "Сейчас жарко")]
        [InlineData(36, "Сейчас очень жарко")]
        [InlineData(45, "Сейчас очень жарко")]
        [InlineData(46, "Я не верю что такая погода может быть!")]
        public void CheckTemperatureEstimate(int temp,string etimate_of_temperature)
        {
            string actual = Homework1.HotorCold(temp);
            Assert.Equal(etimate_of_temperature, actual);
        }
        [Theory]
        [InlineData(2020, 21)]
        [InlineData(1950,20)]
        [InlineData(1890,19)]
        [InlineData(1702,18)]
        [InlineData(1678,17)]
        [InlineData(1527,16)]
        [InlineData(1450,15)]
        [InlineData(1345,14)]
        [InlineData(1220,13)]
        [InlineData(1101,12)]
        [InlineData(1005,11)]
        public void CheckCenturyCorrectDefenition(int year, int century)
        {
            int actual = Homework1.CenturyIS(year);
            Assert.Equal(century, actual);
        }
        [Theory]
        [InlineData(1,3,5,5)]
        [InlineData(45,23,76,76)]
        [InlineData(100,99,98,100)]
        [InlineData(10,15,12,15)]
        [InlineData(35,39,30,39)]
        [InlineData(100,1000,10,1000)]
        public void CheckCorrectMaxNumDefenition(int num1, int num2, int num3, int maxnum)
        {
            int actual = Homework1.GetMaxNum(num1,num2,num3);
            Assert.Equal(maxnum, actual);
        }
        [Theory]
        [InlineData(20,2,10)]
        [InlineData(50,5,10)]
        [InlineData(48,6,8)]
        [InlineData(40,5,8)]
        public void CheckResultAfterDevision(int num1, int num2, int result)
        {
            int actual = Homework1.Devision(num1, num2);
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(550,500)]
        [InlineData(1200,1100)]
        [InlineData(400,400)]
        public void CheckPriceAfterGetDiscont(int prise, int newprice)
        {
            int actual = Homework1.GetNewPrice(prise);
            Assert.Equal(newprice, actual);
        }
        [Theory]
        [InlineData(2, 7,14)]
        [InlineData(62,5,310)]
        [InlineData(25,25,50)]
        [InlineData(101, 200, 301)]
        public void CheckCorrectResultOfOperationAccordingToCondition(int num1, int num2,int result)
        {
            int actual = Homework1_before_courses.GetResultTo_if_else_1(num1, num2);
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(3.5, 8.2, 1)]
        [InlineData(-10.0, 5.4, 2)]
        [InlineData(-4.3, -10.1, 3)]
        [InlineData(11.3, -5.5, 4)]
        public void CheckQuaterDefenition(double x, double y, int quater)
        {
            int actual = Homework1_before_courses.CheckQuater(x, y);
            Assert.Equal(quater, actual);
        }
        [Theory]
        [InlineData(10, 156.5, -25,166.5)]
        [InlineData(-15, 25.5,30,55.5)]
        [InlineData(5,-15,23,28)]
        [InlineData(-22.4,-5.5,-12.3,0)]
        [InlineData(20.5,15.3,87.4,123.2)]
        public void CheckResultOfSumPositiveNumbers(double num1, double num2, double num3, double result)
        {
            double actual = Homework1_before_courses.SumPositiveNumbers(num1,num2,num3);
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(5,7,8,283)]
        [InlineData(25,0,50,78)]
        [InlineData(56,2,1,115)]
        public void CheckResultOfMathExample(double num1, double num2, double num3, double result)
        {
            double actual = Homework1_before_courses.GetResultforMathExample(num1, num2, num3);
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(1, 'F')]
        [InlineData(19, 'F')]
        [InlineData(20, 'E')]
        [InlineData(39, 'E')]
        [InlineData(40, 'D')]
        [InlineData(59, 'D')]
        [InlineData(60, 'C')]
        [InlineData(74, 'C')]
        [InlineData(75, 'B')]
        [InlineData(89, 'B')]
        [InlineData(90, 'A')]
        [InlineData(100, 'A')]
        public void CheckMark(int place, char mark)
        {
            double actual = Homework1_before_courses.GetMark(place);
            Assert.Equal(mark, actual);
        }
    }
}
