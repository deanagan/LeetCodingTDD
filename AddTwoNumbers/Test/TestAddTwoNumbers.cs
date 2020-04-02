using System;
using Xunit;
using FluentAssertions;

namespace Lib.Test
{
    public class UnitTest1
    {
        private Solution sln = new Solution();
        [Fact]
        public void CorrectOutput_WhenAddTwoNumbersInvoked()
        {
            // Arrange
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);


            // Act
            var lres = sln.AddTwoNumbers(l1, l2);

            // Assert
            lres.val.Should().Be(7);
            lres.next.val.Should().Be(0);
            lres.next.next.val.Should().Be(8);
        }

        [Fact]
        public void StringifyCorrect_WhenStringifyingListNode()
        {
            // Arrange
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            // Act
            var num = sln.NumerifyListNode(l1);

            // Assert
            num.Should().Be(243);
        }

        [Fact]
        public void NodifyCorrect_WhenPassingNumber()
        {
            // Arrange
            int num = 243;

            // Act
            var listNode = sln.ReverseNodeNumber(num);

            // Assert
            listNode.val.Should().Be(3);
            listNode.next.val.Should().Be(4);
            listNode.next.next.val.Should().Be(2);
        }
    }
}
