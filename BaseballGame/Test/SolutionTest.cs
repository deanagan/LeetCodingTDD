using Xunit;
using FluentAssertions;

namespace Lib.Test
{
    public class SolutionShould
    {
        [Theory]
        [InlineData(new object[] {new string[]{"5","2","C","D","+"}, 30})]
        public void ReturnCorrectTotal(string[] ops, int expected)
        {
            // Arrange
            var soln = new Solution();
            // Act
            var result = soln.CalPoints(ops);
            // Assert
            result.Should().Be(expected);
        }
    }
}
