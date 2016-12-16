using FluentAssertions;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorShould
    {

        [Test]
        public void Return0_WhenAdding_GivenNoInput()
        {
            var  stringCalculator = new StringCalculator();

            var sum = stringCalculator.Add("");

            sum.Should().Be(0);
        }

        [TestCase("1",1)]
        [TestCase("2",2)]
        [TestCase("10",10)]
        public void ReturnNumber_WhenAdding_GivenSingleNumberToParse(
            string singleNumberToParse, int expectedNumber)
        {
            var stringCalculator = new StringCalculator();

            var number = stringCalculator.Add(singleNumberToParse);

            number.Should().Be(expectedNumber);
        }

        [TestCase("1,1", 2)]
        [TestCase("1,2", 3)]
        [TestCase("2,2", 4)]
        public void ReturnSum_WhenAdding_GivenTwoNumbersToParse(string numbersToParse, int expectedSum)
        {
            var stringCalculator = new StringCalculator();

            var sum = stringCalculator.Add(numbersToParse);

            sum.Should().Be(expectedSum);
        }

        //[TestCase("1,1,1", 3)]
        //public void ReturnSum_WhenAdding_GivenManyNumbersToParse(string numbersToParse, int expectedSum)
        //{
        //    var stringCalculator = new StringCalculator();

        //    var sum = stringCalculator.Add(numbersToParse);

        //    sum.Should().Be(expectedSum);
        //}
    }
}
