using System;
using System.Linq;

namespace AlgorithmCoding
{
    public class CountPrimes
    {
        //Given an integer n, return the number of prime numbers that are strictly less than n.

        //Input: n = 10
        //Output: 4
        //Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.

        public static int CountPrimesResult(int n)
        {
            var isPrime = new bool[n];
            Array.Fill(isPrime, true);

            for (int i = 2; i * i <= n; i++)
            {
                for (int j = i; j * i < n; j++)
                {
                    isPrime[i * j] = false;
                }
            }

            return isPrime.Skip(2).Count(x => x == true);
        }
    }
}
