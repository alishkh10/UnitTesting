namespace UnitTestingAssignment
{
    public class Tests
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
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
    }
}