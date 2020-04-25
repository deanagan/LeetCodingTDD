using System;
using System.Linq;

namespace Lib
{
    public class ReverseInteger
    {
        public int Reverse(int x) {

            var s = string.Join(string.Empty, x.ToString().Reverse().Where(ch => Char.IsDigit(ch)));

            return Convert.ToInt32(s) * (x < 0 ? -1 : 1);
        }
    }
}
