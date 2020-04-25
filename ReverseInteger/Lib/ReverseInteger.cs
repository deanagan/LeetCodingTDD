using System;
using System.Linq;

namespace Lib
{
    public class ReverseInteger
    {

        // Requires zero returned if overflow for int occurs
        public int Reverse(int x) {

            var s = string.Join(string.Empty, x.ToString().Reverse().Where(ch => Char.IsDigit(ch)));
            int result = 0;
            int.TryParse(s, out result);
            return result * (x < 0 ? -1 : 1);
        }
    }
}
