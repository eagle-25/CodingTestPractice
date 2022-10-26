using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Challenges4NewUsers
{
    public class Roman2Integer
    {
        public static int RomanToInt(string s)
        {
            var lomanNumerals = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };
            
            s = s
                .Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");

            return s.AsEnumerable()
                .Select(x => lomanNumerals[x])
                .Sum();
        }
    }
}