using System;
using Xunit;
using FluentAssertions;

namespace PrimeFactorsLib.Test
{
    public class PrimeFactorsShould
    {
        [Theory]
        [InlineData(new object[]{ new int[]{1,2,5}, 10})]
        [InlineData(new object[]{ new int[]{1,2,5}, 20})]
        public void BeCorrect_WhenGettingPrimeFactorsOfNumber(int[] expected, int number)
        {
            // Arrange
            var sut = new PrimeFactors();

            // Act
            var result = sut.PrimeFactorsOf(number);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
