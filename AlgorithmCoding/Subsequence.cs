using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    //Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    //A subsequence of a string is a new string that is formed from the original string by deleting some (can be none)
    //of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

    //Input: s = "abc", t = "ahbgdc"
    //Output: true
    public class Subsequence
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
                return true;

            var sIndex = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s[sIndex])
                {
                    sIndex++;

                    if (sIndex == s.Length)
                        return true;
                }
            }

            return false;
        }
    }
}
