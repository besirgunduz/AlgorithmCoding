using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class TruncateSentence
    {
        //You are given a sentence s​​​​​​ and an integer k​​​​​​.
        //You want to truncate s​​​​​​ such that it contains only the first k​​​​​​ words.
        //Return s​​​​​​ after truncating it.

        //Input: s = "Hello how are you Contestant", k = 4
        //Output: "Hello how are you"

        public static string TruncateSentenceResult(string s, int k)
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
                return s.Substring(0, index - 1);
            }
            else
            {
                return s;
            }
        }

    }
}
