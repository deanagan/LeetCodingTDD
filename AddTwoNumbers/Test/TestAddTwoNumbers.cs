using Xunit;
using Xunit.Abstractions;
using System.Collections.Generic;
using System;
using FluentAssertions;

namespace Lib.Test
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;
        private Solution sln = new Solution();

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }


        private ListNode CreateListNode(List<int> nodeValues)
        {
            ListNode listNode = null;
            ListNode last = null;
            foreach(var num in nodeValues)
            {
                if (listNode != null)
                {
                    var tempNode = new ListNode(num);
                    last.next = tempNode;
                    last = tempNode;
                }
                else
                {
                    listNode = new ListNode(num);
                    listNode.next = null;
                    last = listNode;
                }
            }
            return listNode;
        }
        public static IEnumerable<object[]> Data1 =>
        new List<object[]>
        {
            new object[] { new List<int>{2, 4, 3 }, new List<int>{5, 6, 4 }},
        };
        [Theory]
        [MemberData(nameof(Data1))]
        public void CorrectOutput_WhenAddTwoNumbersInvoked(List<int> n1, List<int> n2)
        {
            // Arrange
            var l1 = CreateListNode(n1);
            var l2 = CreateListNode(n2);

            // Act
            var lres = sln.AddTwoNumbers(l1, l2);

            // Assert
            lres.val.Should().Be(7);
            lres.next.val.Should().Be(0);
            lres.next.next.val.Should().Be(8);
        }


        public static IEnumerable<object[]> Data2 =>
        new List<object[]>
        {
            new object[] { new List<int>{1, 8 }, new List<int>{0 }},
        };
        [Theory]
        [MemberData(nameof(Data2))]
        public void CorrectOutput_WhenAddingZeroAndNumber(List<int> n1, List<int> n2)
        {
            // Arrange
            var l1 = CreateListNode(n1);
            var l2 = CreateListNode(n2);

            // Act
            var lres = sln.AddTwoNumbers(l1, l2);

            // Assert
            lres.val.Should().Be(1);
            lres.next.val.Should().Be(8);
        }

        public static IEnumerable<object[]> Data3 =>
        new List<object[]>
        {
            new object[] { new List<int>{5 }, new List<int>{5 }},
        };
        [Theory]
        [MemberData(nameof(Data3))]
        public void CorrectOutput_WhenAddingWithSingleCarry(List<int> n1, List<int> n2)
        {
            // Arrange
            var l1 = CreateListNode(n1);
            var l2 = CreateListNode(n2);

            // Act
            var lres = sln.AddTwoNumbers(l1, l2);

            // Assert
            lres.val.Should().Be(0);
            lres.next.val.Should().Be(1);
        }

        [Fact]
        public void ArgumentNullExceptionThrown_WhenBothArgumentIsNull()
        {
            Action act = () => sln.AddTwoNumbers(null, null);

            act.Should().ThrowExactly<ArgumentNullException>();

        }
    }
}
