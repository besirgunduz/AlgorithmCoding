﻿namespace AlgorithmCoding
{
    public class LengthOfLastWord
    {
        //Given a string s consists of some words separated by some number of spaces, return the length of the last word in the string.
        //A word is a maximal substring consisting of non-space characters only.

        //Input: s = "Hello World"
        //Output: 5

        //Input: s = "   fly me   to   the moon  "
        //Output: 4

        public static int LastWordCount(string s)
        {
            int count = 0;
            s = s.TrimEnd();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    return count;
                }

                count++;
            }

            return count;
        }
    }
}
