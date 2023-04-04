namespace AlgorithmCoding
{
    public class ValidAnagram
    {
        //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
        //typically using all the original letters exactly once.

        //Input: s = "anagram", t = "nagaram"
        //Output: true

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var charCount = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i] - 'a']++;
                charCount[t[i] - 'a']--;
            }

            foreach (var count in charCount)
            {
                if (count != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
