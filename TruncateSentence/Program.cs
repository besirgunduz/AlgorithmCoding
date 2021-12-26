using System;

namespace TruncateSentence
{
    public class Program
    {
        static void Main(string[] args)
        {
            //You are given a sentence s​​​​​​ and an integer k​​​​​​.
            //You want to truncate s​​​​​​ such that it contains only the first k​​​​​​ words.
            //Return s​​​​​​ after truncating it.

            //Input: s = "Hello how are you Contestant", k = 4
            //Output: "Hello how are you"

            string s = "Hello how are you Contestant";
            int k = 4;
            Console.WriteLine(TruncateSentence(s, k));


        }

        private static string TruncateSentence(string s, int k)
        {
            int index = 0;
            int spaceCount = 0;
            while (index < s.Length && spaceCount < k)
            {
                if (s[index] == ' ')
                {
                    spaceCount++;
                }

                index++;
            }

            if (spaceCount == k)
            {
                return s.Substring(0, index-1);
            }
            else
            {
                return s;
            }
        }
    }
}
