using System.Net.Http.Headers;

namespace UnitTestingAssignment
{
    public class Tests
    {
        private FizzBuzz fizzBuzz;
        private LeapYear leapYear;
        private CalcStats calcStats;
        private int[] inputData = { 1, 4, -3, -6, 17, 5235, -77, 5, 41, 8};
        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
            leapYear = new LeapYear();
            calcStats = new CalcStats()
        }

        [Test]
        public void FizzBuzzShouldReturnCorrectValue()
        {
            Assert.AreEqual("4", fizzBuzz.GetFizzBuzz(4));
            Assert.AreEqual("17", fizzBuzz.GetFizzBuzz(17));
            Assert.AreEqual("Fizz", fizzBuzz.GetFizzBuzz(3));
            Assert.AreEqual("Buzz", fizzBuzz.GetFizzBuzz(5));
            Assert.AreEqual("FizzBuzz", fizzBuzz.GetFizzBuzz(15));
        }

        [Test]
        public void FizzBuzzShouldReturnOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.GetFizzBuzz(101));
            Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.GetFizzBuzz(0));
        }

        [Test]
        public void LeapYearShouldReturnCorrectValue()
        {
            Assert.AreEqual(true, leapYear.GetLeapYearResult(2024));
            Assert.AreEqual(true, leapYear.GetLeapYearResult(1024));
            Assert.AreEqual(false, leapYear.GetLeapYearResult(2025));
            Assert.AreEqual(false, leapYear.GetLeapYearResult(1025));
        }

        [Test]
        public void CalcStatShouldReturnMinValue()
        {
            int result = calcStats.GetMinResult(inputData);
            Assert.AreEqual(-77, result);
        }

        [Test]
        public void CalcStatShouldReturnMaxValue()
        {
            int result = calcStats.GetMaxResult(inputData);
            Assert.AreEqual(5235, result);
        }

        [Test]
        public void CalcStatShouldReturnAvgValue()
        {
            int result = calcStats.GetAvgResult(inputData);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CalcStatShouldReturnNumberOfValues()
        {
            int result = calcStats.GetMinResult(inputData);
            Assert.AreEqual(10, result);
        }
    }
}