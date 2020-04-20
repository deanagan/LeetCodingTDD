using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class LengthOfLongestSubstringFinder
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            var length = 0;
            var sindex = 0;
            var slen = s.Length;

            while ((length + sindex) < slen)
            {
                var tempSubSet = new HashSet<char>();
                var sub = string.Join(string.Empty, s.Skip(sindex).TakeWhile(ch => tempSubSet.Add(ch)));
                length = Math.Max(sub.Count(), length);
                sindex++;
            }

            return length;
        }
    }
}
