
using System;

namespace Lib
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
    }

    public class Solution
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                throw new ArgumentNullException("Arguments should not be null");
            }
            ListNode result = null;
            ListNode last = null;
            var carry = 0;
            while (l1 != null || l2 != null || carry > 0)
            {
                var num = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                carry = (num >= 10) ? 1 : 0;
                var temp = new ListNode(num % 10);
                temp.next = null;

                if (result != null)
                {
                    last.next = temp;
                    last = temp;
                }
                else
                {
                    result = temp;
                    last = result;
                }
                l1 = l1?.next ?? null;
                l2 = l2?.next ?? null;
            }

            return result;
        }
    }
}
