namespace UnitTestingAssignment
{
    public class Tests
    {
        private FizzBuzz fizzBuzz;
        private LeapYear leapYear;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
            leapYear = new LeapYear();
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
            Assert.AreEqual(true, leapYear.GetLearYearResult(2024));
            Assert.AreEqual(true, leapYear.GetLearYearResult(1024));
            Assert.AreEqual(false, leapYear.GetLearYearResult(2025));
            Assert.AreEqual(false, leapYear.GetLearYearResult(1025));
        }
    }
}