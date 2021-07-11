using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
            //  Symbol      Value
            //  I             1
            //  V             5
            //  X             10
            //  L             50
            //  C             100
            //  D             500
            //  M             1000

            //Input: s = "III"
            //Output: 3
            //
            //Input: s = "LVIII"
            //Output: 58

            string s = "LVIII";
            int result = 0;

            var dic = new Dictionary<char, int>
            {
                {'I',1 },{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000} //VI = 6
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && dic[s[i]] < dic[s[i + 1]])
                {
                    result -= dic[s[i]];
                }
                else
                {
                    result += dic[s[i]];
                }
            }

            Console.WriteLine(result);
        }
    }
}
