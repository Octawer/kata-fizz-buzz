using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace FizzBuzzKata.XUnit.Tests.FizzBuzzTests
{
    public class SerializeShould
    {
        [Fact]
        public void Not_be_empty()
        {
            var sut = new FizzBuzz();

            var result = sut.Serialize(1, 1);

            result.Should().NotBeEmpty();
        }

        [Theory]
        [InlineData(150, 100)]
        [InlineData(1, -1)]
        [InlineData(1, 0)]
        public void Throw_notSupportedException_when_start_greater_than_end(int start, int end)
        {
            var sut = new FizzBuzz();

            Action action = () => sut.Serialize(start, end);

            action.Should().Throw<NotSupportedException>();
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, 100, 100)]
        [InlineData(0, 10, 11)]
        [InlineData(10, 10, 1)]
        [InlineData(1000, 1200, 201)]
        [InlineData(-10, 10, 21)]
        public void Have_end_less_start_plus_one_elements(int start, int end, int count)
        {
            var sut = new FizzBuzz();

            var result = sut.Serialize(start, end);

            result.Should().HaveCount(count);
        }

        [Theory]
        [InlineData(1, 100)]
        [InlineData(1, 200)]
        [InlineData(-10, 150)]
        public void Limit_to_bounds(int start, int end)
        {
            var sut = new FizzBuzz();

            var result = sut.Serialize(start, end);

            var outOfBounds = result.Any(fizzBuzzResult => IsOutOfBounds(fizzBuzzResult, start, end));

            outOfBounds.Should().BeFalse();
        }

        [Theory]
        [InlineData(1, 10, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" })]
        public void Convert_to_fizzbuzz_series(int start, int end, string[] expected)
        {
            var sut = new FizzBuzz();

            var result = sut.Serialize(start, end);

            result.Should().BeEquivalentTo(expected);
        }

        private bool IsOutOfBounds(string fizzBuzzResult, int start, int end)
        {
            if (int.TryParse(fizzBuzzResult, out var number))
            {
                return number < start || number > end;
            }

            return false;
        }
    }
}
