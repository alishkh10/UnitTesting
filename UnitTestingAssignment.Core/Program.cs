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

    public class CalcStats
    {
        public int GetMinResult(int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }

        public int GetMaxResult(int[] numbers)
        {
            int max = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }    
            }

            return max;
        }

        public int GetLengthResult(int[] numbers)
        {
            int count = 0;

            foreach (var num in numbers)
            {
                count++;
            }

            return count;
        }

        public double GetAvgResult(int[] numbers)
        {
            double sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum / GetLengthResult(numbers);
        }
    }
}