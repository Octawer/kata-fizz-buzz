using FluentAssertions;
using Xunit;

namespace FizzBuzzKata.XUnit.Tests.FizzBuzzTests
{
    public class ConvertShould
    {
        [Fact]
        public void Return_1_when_1()
        {
            // arrange
            var sut = new FizzBuzz();

            // act
            var result = sut.Convert(1);

            // assert
            result.Should().Be("1");
        }

        [Fact]
        public void Return_2_when_2()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(2);

            result.Should().Be("2");
        }

        [Fact]
        public void Return_Fizz_when_3()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(3);

            result.Should().Be("Fizz");
        }

        [Fact]
        public void Return_Fizz_when_6()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(6);

            result.Should().Be("Fizz");
        }

        [Fact]
        public void Return_Fizz_when_9()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(9);

            result.Should().Be("Fizz");
        }

        [Fact]
        public void Return_4_when_4()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(4);

            result.Should().Be("4");
        }

        [Fact]
        public void Return_Buzz_when_5()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(5);

            result.Should().Be("Buzz");
        }

        [Fact]
        public void Return_Buzz_when_10()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(10);

            result.Should().Be("Buzz");
        }

        [Fact]
        public void Return_FizzBuzz_when_15()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(15);

            result.Should().Be("FizzBuzz");
        }

        [Fact]
        public void Return_FizzBuzz_when_30()
        {
            var sut = new FizzBuzz();

            var result = sut.Convert(30);

            result.Should().Be("FizzBuzz");
        }
    }
}
