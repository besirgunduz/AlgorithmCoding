using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class ValidPalindrome
    {
        //A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
        //it reads the same forward and backward. Alphanumeric characters include letters and numbers.

        //Input: s = "race a car"
        //Output: false

        public static bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
            {
                return true;
            }

            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!char.IsLetterOrDigit(s[start])){
                    start++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[end])){
                    end--;
                    continue;
                }

                if (char.ToLower(s[start]) != char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
