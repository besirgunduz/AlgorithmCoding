using System;
using System.Collections.Generic;

namespace IsomorphicStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Given two strings s and t, determine if they are isomorphic.

            //Two strings s and t are isomorphic if the characters in s can be replaced to get t.

            //All occurrences of a character must be replaced with another character while preserving the order of characters.
            //No two characters may map to the same character, but a character may map to itself.

            //Input: s = "egg", t = "add"
            //Output: true

            var s = "egg";
            var t = "add";
            Console.WriteLine(IsIsomorphic(s, t));
        }

        private static bool IsIsomorphic(string s, string t)
        {
            var dic = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dic.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dic.Add(s[i], t[i]);
                    }
                }
            }

            return true;
        }
    }
}
