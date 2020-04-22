using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class LongestPalindromicSubstringFinder
    {
        public string LongestPalindrome(string s) {
            if (s.Length == 1)
            {
                return s;
            }
            var length = s.Length;
            var longestPalindrome = string.Empty;
            while (length > 1)
            {
                var i = 0;
                while (i + length <= s.Length)
                {
                    var sub = s.Substring(i, length);
                    if (sub == string.Join(string.Empty, sub.Reverse()))
                    {
                        if (length > longestPalindrome.Length)
                        {
                            longestPalindrome = sub;
                        }
                    }
                    i++;
                }

                length--;
            }
            return longestPalindrome;
        }
    }
}
