using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace Lib.Test
{
    public class TownJudgeFinderShould
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 2, 2, new int[1][] { new []{1,2}}};
            yield return new object[] { 3, 3, new int[2][] { new []{1,3}, new []{2,3}}};
            yield return new object[] { 3, -1, new int[3][] { new []{1,3}, new []{2,3}, new []{3,1}}};
            yield return new object[] { 3, -1, new int[2][] { new []{1,2}, new []{2,3}}};
            yield return new object[] { 4, 3, new int[5][] { new []{1,3}, new []{1,4}, new []{2,3}, new []{2,4}, new []{4,3}}};
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void FindTheJudge_WhenGivenTrustArrays(int n, int expected, int[][] trust)
        {
            // Arrange
            var townJudgeFinder = new TownJudgeFinder();
            // Act
            var result = townJudgeFinder.FindJudge(n, trust);
            // Assert
            result.Should().Be(expected);
        }
    }
}
