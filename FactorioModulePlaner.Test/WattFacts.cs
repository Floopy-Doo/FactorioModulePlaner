using FluentAssertions;
using Xunit;

namespace FactorioModulePlaner.Test
{
    public class WattFacts
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 5, 50)]
        [InlineData(100, -1, -100)]
        public void ShouldCalculateMultipleOf(decimal initial, decimal multiply, decimal expected)
        {
            var testee = new Watt(initial);

            Watt result = testee * multiply;

            result.Should().Be(new Watt(expected));
        }

        [Fact]
        public void FactoryShouldCreateAMultipleOf1000()
        {
            Watt result = Watt.FromKiloWatts(2);

            result.Should().Be(new Watt(2 * 1000));
        }

        [Fact]
        public void FactoryShouldCreateAMultipleOf1000000()
        {
            Watt result = Watt.FromMegaWatts(2);

            result.Should().Be(new Watt(2 * 1000 * 1000));
        }

        [Fact]
        public void FactoryShouldCreateSameAsNormalConstructor()
        {
            Watt result = Watt.FromWatts(2);

            result.Should().Be(new Watt(2));
        }


        [Fact]
        public void ShouldConvertFromDecimal()
        {
            Watt result = Watt.FromWatts(2);

            result.Should().Be(new Watt(2));
        }
    }
}