using System;
using Xunit;
using FluentAssertions;

namespace Lib.Test
{
    public class LongestPalindromicSubstringFinderTest
    {
        [Theory]
        [InlineData(new object[]{"pppp", new string[] {"pppp"}})]
        [InlineData(new object[]{"babad", new string[] {"bab", "aba"}})]
        [InlineData(new object[]{"cbbd", new string[] {"bb"}})]
        [InlineData(new object[]{"a", new string[] {"a"}})]
        [InlineData(new object[]{"ac", new string[] {"a", "c"}})]
        [InlineData(new object[]{"", new string[] {""}})]
        public void PalindromSubstringCorrect_WhenReceivingString(string input, string[] possiblePalindromes)
        {
            // Arrange
            var sut = new LongestPalindromicSubstringFinder();
            // Act
            var result = sut.LongestPalindrome(input);
            // Assert
            result.Should().BeOneOf(possiblePalindromes);
        }
    }
}
