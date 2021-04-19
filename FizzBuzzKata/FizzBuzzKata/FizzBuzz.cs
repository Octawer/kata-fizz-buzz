using System;
using System.Linq;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Convert(int number)
        {
            bool isMultipleOfThree = number % 3 == 0;
            bool isMultipleOfFive = number % 5 == 0;

            if (isMultipleOfThree && isMultipleOfFive) return "FizzBuzz";

            if (isMultipleOfThree) return "Fizz";

            if (isMultipleOfFive) return "Buzz";

            return $"{number}";
        }

        public string[] Serialize(int start, int end) 
        {
            if (start > end)
                throw new NotSupportedException($"Invalid params: {start} is > {end}");

            int count = end - start + 1;
            return Enumerable.Range(start, count).Select(number => Convert(number)).ToArray();
        }
    }
}
