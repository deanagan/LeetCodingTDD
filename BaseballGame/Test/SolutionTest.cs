using Xunit;
using FluentAssertions;

namespace Lib.Test
{
    public class SolutionShould
    {
        [Theory]
        [InlineData(new object[] {new string[]{"5","2","C","D","+"}, 30})]
        [InlineData(new object[] {new string[]{"5","-2","4","C","D","9","+","+"}, 27})]
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
