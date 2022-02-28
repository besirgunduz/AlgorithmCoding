using System;
using System.Collections.Generic;

namespace RansomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
            //Each letter in magazine can only be used once in ransomNote.

            //Input: ransomNote = "aa", magazine = "aab"
            //Output: true

            Console.WriteLine(CanConstruct("aa", "aab"));

        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var dic = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }

            foreach (var r in ransomNote)
            {
                if (!dic.ContainsKey(r) || dic[r] <= 0)
                {
                    return false;
                }

                dic[r]--;
            }

            return true;
        }
    }
}
