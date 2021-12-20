using System;

namespace ShuffleString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given a string s and an integer array indices of the same length.
            //The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
            //Return the shuffled string.

            //Input: s = "codeleet", indices = [4, 5, 6, 7, 0, 2, 1, 3]
            //Output: "leetcode"
            //Explanation: As shown, "codeleet" becomes "leetcode" after shuffling.

            var s = "codeleet";
            var indices = new int[] { 4, 5, 6, 7, 0, 2, 1, 3 };
            Console.WriteLine(RestoreString(s, indices));

        }

        private static string RestoreString(string s, int[] indices)
        {
            var newArray = new char[indices.Length];

            for (int i = 0; i < indices.Length; i++)
            {
                newArray[indices[i]] = s[i];
            }

            //return new string(newArray);
            return string.Join("", newArray);
        }
    }
}
