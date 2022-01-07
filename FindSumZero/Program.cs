using System;

namespace FindSumZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer n, return any array containing n unique integers such that they add up to 0.

            //Input: n = 5
            //Output:[-7,-1,1,3,4]
            //Explanation: These arrays also are accepted[-5, -1, 1, 2, 3] , [-3,-1,2,-2,4].

            //Input: n = 1
            //Output:[0]

            var n = 25;
            Console.WriteLine(string.Join(",", SumZero(n)));
        }

        private static int[] SumZero(int n)
        {
            var result = new int[n];
            var start = 0;
            var end = n - 1;
            var count = 1;

            while (start < end)
            {
                result[start] = count;
                result[end] = -count;

                count++;
                start++;
                end--;
            }

            return result;
        }
    }
}
