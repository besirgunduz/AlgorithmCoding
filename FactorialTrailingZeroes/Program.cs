using System;

namespace FactorialTrailingZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer n, return the number of trailing zeroes in n!.

            //Input: n = 5
            //Output: 1
            //Explanation: 5! = 120, one trailing zero.

            Console.WriteLine(TrailingZeroes(5));
        }

        private static int TrailingZeroes(int n)
        {
            var counter = 0;

            while (n > 0)
            {
                n /= 5;
                counter += n;
            }

            return counter;
        }
    }
}
