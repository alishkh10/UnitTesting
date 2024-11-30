namespace UnitTestingAssignment
{
    public class FizzBuzz
    {
        public static void Main() { }
        public string GetFizzBuzz(int number)
        {
            if (number < 1 || number > 100)
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be within the range 1 to 100.");

            if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
    public class LeapYear
    {
        public bool GetLeapYearResult(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}