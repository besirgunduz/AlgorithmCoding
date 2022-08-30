using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class JewelsAndStones
    {
        //You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have.
        //Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
        //Letters are case sensitive, so "a" is considered a different type of stone from "A".

        //Input: jewels = "aA", stones = "aAAbbbb"
        //Output: 3

        public static int JewelsAndStonesResult(string jewels, string stones)
        {
            var count = 0;
            var set = new HashSet<char>(jewels);

            foreach (var stone in stones)
            {
                if (set.Contains(stone))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
