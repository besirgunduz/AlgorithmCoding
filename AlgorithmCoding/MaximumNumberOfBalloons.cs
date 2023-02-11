using System;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

namespace AlgorithmCoding
{
    public class MaximumNumberOfBalloons
    {
        //Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
        //You can use each character in text at most once.Return the maximum number of instances that can be formed.

        //Input: text = "loonbalxballpoon"
        //Output: 2

        public static int MaximumNumberOfBalloonsResult(string text)
        {
            var charCount = new int[26];

            foreach (char c in text)
                charCount[c - 'a']++;

            var min = charCount[1];//b
            min = Math.Min(min, charCount[0]);//a
            min = Math.Min(min, charCount[11] / 2);//l
            min = Math.Min(min, charCount[14] / 2);//o
            min = Math.Min(min, charCount[13]);//n

            return min;
        }
    }
}
