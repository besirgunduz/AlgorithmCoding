using System;
using System.Collections.Generic;

namespace DetermineIfStringHalvesAreAlike
{
    public class Program
    {
        static void Main(string[] args)
        {
            //You are given a string s of even length.Split this string into two halves of equal lengths, and let a be the first half and b be the second half.
            //Two strings are alike if they have the same number of vowels('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'). Notice that s contains uppercase and lowercase letters.
            //Return true if a and b are alike. Otherwise, return false.

            //Input: s = "textbook"
            //Output: false
            //Explanation: a = "text" and b = "book"

            string s = "textbook";
            Console.WriteLine(HalvesAreAlike(s));
            Console.ReadKey();
        }

        private static bool HalvesAreAlike(string s)
        {
            var charSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', };

            var start = 0;
            var end = s.Length - 1;

            var firstCount = 0;
            var secondCount = 0;


            while (end > start)
            {
                firstCount += charSet.Contains(s[start++]) ? 1 : 0;
                secondCount += charSet.Contains(s[end--]) ? 1 : 0;
            }

            return firstCount == secondCount;
        }
    }
}
