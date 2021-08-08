using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a function to find the longest common prefix string amongst an array of strings.

            //If there is no common prefix, return an empty string "".

            //Input: strs = ["flower", "flow", "flight"]
            //Output: "fl"

            //Input: strs = ["dog", "racecar", "car"]
            //Output: ""

            var strs = new string[] { "flover", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));

        }

        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (String.IsNullOrEmpty(prefix)) return "";
                }
            }

            return prefix;

        }
    }
}
