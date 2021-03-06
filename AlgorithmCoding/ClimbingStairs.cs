using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class ClimbingStairs
    {
        //You are climbing a staircase.It takes n steps to reach the top.
        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top ?

        //Input: n = 3
        //Output: 3
        //Explanation: There are three ways to climb to the top.
        //1. 1 step + 1 step + 1 step
        //2. 1 step + 2 steps
        //3. 2 steps + 1 step

        public static int ClimbingStairsResult(int n)
        {
            int count = 0;

            int step1 = 1;
            int step2 = 1;

            if (n == 1)
                return 1;

            if (n == 2)
                return 2;

            for (int i = 3; i <= n + 1; i++)
            {
                count = 0;
                count = step1 + step2;
                step1 = step2;
                step2 = count;

            }

            return count;
        }
    }
}
