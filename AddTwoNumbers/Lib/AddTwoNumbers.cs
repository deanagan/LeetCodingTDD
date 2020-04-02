using System;
using System.Text;
using System.Linq;

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
        public int NumerifyListNode(ListNode l)
        {
            if (l == null)
            {
                return 0;
            }

            var result = new StringBuilder();
            result.Append(l.val);

            while(l.next != null)
            {
                l = l.next;
                result.Append(l.val.ToString());
            }
            return Convert.ToInt32(result.ToString());
        }

        public ListNode ReverseNodeNumber(int number)
        {
            ListNode resultListNode = null;
            foreach(var num in number.ToString().Select(nch => nch - '0'))
            {
                if (resultListNode == null)
                {
                    resultListNode = new ListNode(num);
                    resultListNode.next = null;
                }
                else
                {
                    var tempListNode = new ListNode(num);
                    tempListNode.next = resultListNode;
                    resultListNode = tempListNode;
                }
            }
            return resultListNode;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = NumerifyListNode(l1) + NumerifyListNode(l2);
            return ReverseNodeNumber(result);
        }
    }
}
