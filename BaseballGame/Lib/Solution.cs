using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class Solution
    {
        public int CalPoints(string[] ops) {
            var infoStack = new Stack<int>();
            var total = 0;
            foreach(var info in ops) {
                if (info == "C") {
                    if (infoStack.Count > 0)
                    {
                        var m = infoStack.Pop();
                        total -= m;
                    }
                } else if (info == "D") {
                    var dresult = infoStack.Peek() * 2;
                    infoStack.Push(dresult);
                    total += dresult;
                } else if (info == "+") {
                    var last2total = infoStack.Take(2).Sum();
                    infoStack.Push(last2total);
                    total += last2total;
                } else {
                    infoStack.Push(Convert.ToInt32(info));
                    total += infoStack.Peek();
                }

            }
            return total;
        }
    }
}
