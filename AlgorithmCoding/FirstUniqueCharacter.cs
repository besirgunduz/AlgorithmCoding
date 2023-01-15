using System.Collections.Generic;

namespace AlgorithmCoding
{
    public class FirstUniqueCharacter
    {
        //Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

        //Input: s = "loveleetcode"
        //Output: 2

        public static int FirstUniqueCharacterResult(string s)
        {
            var dic = new Dictionary<char, int>();

            foreach (char item in s)
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

            foreach (var item in s)
            {
                if (dic[item] == 1)
                {
                    return s.IndexOf(item);
                }
            }

            return -1;
        }
    }
}
