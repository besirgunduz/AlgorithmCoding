using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class HappyNumber
    {
        //Write an algorithm to determine if a number n is happy.
        //Starting with any positive integer, replace the number by the sum of the squares of its digits.
        //Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        //Those numbers for which this process ends in 1 are happy.

        //Input: n = 19
        //Output: true
        //Explanation:
        //1^2 + 9^2 = 82
        //8^2 + 2^2 = 68
        //6^2 + 8^2 = 100
        //1^2 + 0^2 + 0^2 = 1

        public static bool IsHappy(int n)
        {
            var seenNumbers = new List<int>();

            while (n > 1 && !seenNumbers.Contains(n))
            {
                seenNumbers.Add(n);
                n = SumDigitsSquare(n);
            }

            return n == 1;
        }

        public static int SumDigitsSquare(int n)
        {
            var total = 0;

            while (n > 0)
            {
                total += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }

            return total;
        }
    }
}
