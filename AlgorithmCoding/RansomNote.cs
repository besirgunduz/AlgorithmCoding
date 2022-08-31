using System.Collections.Generic;

namespace AlgorithmCoding
{
    public static class RansomNote
    {
        //Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
        //Each letter in magazine can only be used once in ransomNote.

        //Input: ransomNote = "aa", magazine = "aab"
        //Output: true

        //Input: ransomNote = "aa", magazine = "ab"
        //Output: false

        public static bool RansomNoteResult(string ransomNote, string magazine)
        {
            var dic = new Dictionary<char, int>();

            foreach (var item in magazine)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            foreach (var item in ransomNote)
            {
                if (!dic.ContainsKey(item) || dic[item] <= 0)
                {
                    return false;
                }

                dic[item]--;
            }

            return true;
        }
    }
}
