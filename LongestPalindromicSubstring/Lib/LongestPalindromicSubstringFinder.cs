using System.Text;
using System.Linq;

namespace Lib
{
    public class LongestPalindromicSubstringFinder
    {
        private string ScanNLengthPalindrome(int index, string s, bool isOddLengthPalindrome)
        {
            var isPalindrome = false;
            var length = isOddLengthPalindrome ? 1 : 0;
            var offset = isOddLengthPalindrome ? 1 : 0;
            var rem = isOddLengthPalindrome ? 0 : 1;
            var sb = new StringBuilder();

            if (isOddLengthPalindrome == true)
            {
                sb.Append(s[index]);
            }

            do {
                isPalindrome = s[index + offset] == s[index - (rem + offset)];
                if (isPalindrome)
                {
                    sb.Append(s[index + offset]);
                    sb.Insert(0, s[index + offset]);
                }
                length += 2;
                offset++;

            } while(isPalindrome && (index + offset < s.Length) && ((index - (rem + offset)) >= 0));

            return sb.ToString();
        }

        public string LongestPalindrome(string s) {
            if (s.Length < 2)
            {
                return s;
            }
            if (s.Length == 2)
            {
                if (s[0] == s[1])
                {
                    return s;
                }
                return s[0].ToString();
            }
            var length = s.Length;
            var longestPalindrome = string.Empty;
            for(var index = 1; index < (length - 1); index++)
            {
                var p = ScanNLengthPalindrome(index, s, true);
                if (p.Length > longestPalindrome.Length)
                {
                    longestPalindrome = p;
                }

                p = ScanNLengthPalindrome(index, s, false);
                if (p.Length > longestPalindrome.Length)
                {
                    longestPalindrome = p;
                }
            }

            if ((s[length - 1] == s[length - 2]) && (longestPalindrome.Length < 2))
            {
                longestPalindrome = s[length - 1].ToString() + s[length - 2].ToString();
            }
            return longestPalindrome;
        }
    }
}
