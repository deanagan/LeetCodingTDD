using System;
using System.Collections.Generic;

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
                    if (infoStack.Count > 0) {
                        var last = infoStack.Pop();
                        var last2 = infoStack.Count > 0 ? infoStack.Peek() : 0;
                        var last2Total = last + last2;
                        infoStack.Push(last);
                        infoStack.Push(last2Total);
                        total += last2Total;
                    }
                } else {
                    infoStack.Push(Convert.ToInt32(info));
                    total += infoStack.Peek();
                }

            }
            return total;
        }
    }
}
