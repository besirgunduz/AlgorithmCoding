using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    // Given an integer, write a function to determine if it is a power of two.

    //Input: n = 16
    //Output: true

    public static class PowerOfThree
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }

            while (n % 3 == 0)
            {
                n /= 3;
            }

            return n == 1;
        }
    }
}
