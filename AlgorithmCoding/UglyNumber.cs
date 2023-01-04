using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class UglyNumber
    {
        //An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.
        //Given an integer n, return true if n is an ugly number.

        //Input: n = 6
        //Output: true
        //Explanation: 6 = 2 × 3
        public static bool IsUgly(int n)
        {
            if (n <= 0)
                return false;

            while (n % 2 == 0)
            {
                n /= 2;
            }

            while (n % 3 == 0)
            {
                n /= 3;
            }

            while (n % 5 == 0)
            {
                n /= 5;
            }

            return n == 1;
        }
    }
}
