using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzConverter = new FizzBuzz();
            var fizzBuzzSeries = fizzBuzzConverter.Serialize(1, 100);

            foreach (var result in fizzBuzzSeries)
            {
                Console.WriteLine(result);
            }
        }
    }
}
