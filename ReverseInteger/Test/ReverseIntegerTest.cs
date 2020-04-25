using System;
using Xunit;
using FluentAssertions;

namespace Lib.Test
{
    public class ReverseIntegerTestShould
    {
        [Theory]
        [InlineData(new object[] {0, 0})]
        [InlineData(new object[] {123, 321})]
        [InlineData(new object[] {-123, -321})]
        [InlineData(new object[] {120, 21})]
        [InlineData(new object[] {1534236469, 0})]
        public void ReverseInteger(int input, int expected)
        {
            // Arrange
            var sut = new ReverseInteger();
            // Act
            var result = sut.Reverse(input);
            // Assert
            result.Should().Be(expected);
        }
    }
}
