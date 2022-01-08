using System;
using System.Text;

namespace RepeatedSubstringPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.

            //Input: s = "abab"
            //Output: true

            //Input: s = "abcabcabcabc"
            //Output: true

            var s = "ababab";
            Console.WriteLine(RepeatedSubstringPattern(s));
        }

        private static bool RepeatedSubstringPattern(string s)
        {
            for (int i = s.Length / 2; i >= 1; i--)
            {
                var repeatCount = s.Length / i;
                var subStr = s.Substring(0, i);
                var sb = new StringBuilder();

                for (int j = 0; j < repeatCount; j++)
                {
                    sb.Append(subStr);
                }

                if (sb.ToString() == s)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
