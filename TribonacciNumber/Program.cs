using System;

namespace TribonacciNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            //The Tribonacci sequence Tn is defined as follows: 
            //T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn + 1 + Tn + 2 for n >= 0.
            //Given n, return the value of Tn.

            //Input: n = 4
            //Output: 4

            //Input: n = 25
            //Output: 1389537

            var n = 25;
            Console.WriteLine(Tribonacci(n));
        }

        private static int Tribonacci(int n)
        {
            var arr = new int[n + 3];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;

            for (int i = 3; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }

            return arr[n];
        }
    }
}
