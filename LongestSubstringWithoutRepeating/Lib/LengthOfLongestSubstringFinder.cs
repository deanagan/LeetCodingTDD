using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class LengthOfLongestSubstringFinder
    {
        public int LengthOfLongestSubstring(string s)
        {
            var slen = s.Length;
            if (slen == 0) { return 0; }
            var charEntryCount = new Dictionary<char, int>();
            var startIndex = 0;
            var length = 0;
            foreach(var indexAndChar in s.Select((value,index) => new {value, index}))
            {
                if (charEntryCount.ContainsKey(indexAndChar.value))
                {
                    startIndex = Math.Max(charEntryCount[indexAndChar.value] + 1, startIndex);
                }
                length = Math.Max(indexAndChar.index - startIndex + 1, length);
                charEntryCount[indexAndChar.value] = indexAndChar.index;
            }

            return length;
        }
    }
}
