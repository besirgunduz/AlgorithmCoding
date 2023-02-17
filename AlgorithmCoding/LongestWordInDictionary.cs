using System;
using System.Collections.Generic;

namespace AlgorithmCoding
{
    public class LongestWordInDictionary
    {
        //Given an array of strings words representing an English Dictionary, return the longest word in words that can be built one character at a time by other words in words.
        //If there is more than one possible answer, return the longest word with the smallest lexicographical order.If there is no answer, return the empty string.
        //Note that the word should be built from left to right with each additional character being added to the end of a previous word. 

        //Input: words = ["a","banana","app","appl","ap","apply","apple"]
        //Output: "apple"

        public static string LongestWord(string[] words)
        {
            Array.Sort(words);
            var hashSet = new HashSet<string>();
            var result = String.Empty;

            foreach (var word in words)
            {
                if (word.Length == 1 || hashSet.Contains(word.Substring(0, word.Length - 1)))
                {
                    if (word.Length > result.Length)
                        result = word;

                    hashSet.Add(word);
                }
            }
            return result;
        }

    }
}
