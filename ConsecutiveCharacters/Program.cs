using System;

namespace ConsecutiveCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            //The power of the string is the maximum length of a non-empty substring that contains only one unique character.
            // 1 <= s.length <= 500 Given a string s, return the power of s.

            //Input: s = "abbcccddddeeeeedcba"
            //Output: 5
            //Explanation: The substring "eeeee" is of length 5 with the character 'e' only.

            var s = "abbcccddddeeeeedcba";
            Console.WriteLine(MaxPower(s));
        }

        private static int MaxPower(string s)
        {
            int ayniKarakterSayisi = 1;
            int max = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    ayniKarakterSayisi++;
                }
                else
                {
                    ayniKarakterSayisi = 1;
                }

                if (ayniKarakterSayisi > max)
                {
                    max = ayniKarakterSayisi;
                }

            }

            return max;
        }
    }
}
