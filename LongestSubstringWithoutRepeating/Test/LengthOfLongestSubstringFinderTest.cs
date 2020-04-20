using System;
using Xunit;
using FluentAssertions;

namespace Lib.Test
{
    public class LengthOfLongestSubstringFinderShould
    {
        [Theory]
        [InlineData (new object[] {"abcabcbb", 3})]
        [InlineData (new object[] {"bbbbb", 1})]
        [InlineData (new object[] {"pwwkew", 3})]
        [InlineData (new object[] {"au", 2})]
        [InlineData (new object[] {"dvdf", 3})]
        public void ReturnCorrectLengthOfLongestSubstring(string s, int expectedLength)
        {
            // Arrange
            var sut = new LengthOfLongestSubstringFinder();
            // Act
            var length = sut.LengthOfLongestSubstring(s);
            // Assert
            length.Should().Be(expectedLength);
        }
    }
}
