using System;
using System.Collections.Generic;

namespace JewelsAndStones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have.
            //Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
            //Letters are case sensitive, so "a" is considered a different type of stone from "A".

            //Input: jewels = "aA", stones = "aAAbbbb"
            //Output: 3

            Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb"));
        }

        private static int NumJewelsInStones(string jewels, string stones)
        {
            var count = 0;
            var hashSat = new HashSet<char>(jewels);

            foreach (var s in stones)
            {
                if (hashSat.Contains(s))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
