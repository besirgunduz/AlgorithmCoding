using Microsoft.VisualBasic;
using System.ComponentModel;

namespace AlgorithmCoding
{
    public class BalancedStringSplit
    {
        //Balanced strings are those that have an equal quantity of 'L' and 'R' characters.
        //Given a balanced string s, split it into some number of substrings such that:
        //Return the maximum number of balanced strings you can obtain.

        //Input: s = "RLRRLLRLRL"
        //Output: 4
        //Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.

        public static int BalancedStringSplitResult(string s)
        {
            var result = 0;
            var count = 0;

            foreach (var c in s)
            {
                if (c == 'R')
                    count++;
                else
                    count--;

                if (count == 0)
                    result++;
            }

            return result;
        }
    }
}
