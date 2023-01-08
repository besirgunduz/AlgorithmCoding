using System.Collections.Generic;

namespace AlgorithmCoding
{
    public class RomanToInteger
    {
        // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        //Roman numerals are usually written largest to smallest from left to right.However,
        //the numeral for four is not IIII. Instead, the number four is written as IV.
        //Because the one is before the five we subtract it making four.
        //The same principle applies to the number nine, which is written as IX.
        //There are six instances where subtraction is used:

        //Input: s = "MCMXCIV"
        //Output: 1994
        //Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
        public static int RomanToIntegerResult(string s)
        {
            var dic = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            var result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && dic[s[i]] < dic[s[i + 1]])
                    result -= dic[s[i]];
                else
                    result += dic[s[i]];
            }

            return result;
        }
    }
}
