using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given a square matrix, calculate the absolute difference between the sums of its diagonals

            List<List<int>> arr = new List<List<int>>();

            arr.Add(new List<int> { 11, 2, 4 });
            arr.Add(new List<int> { 4, 5, 6 });
            arr.Add(new List<int> { 10, 8, -12 });

            Console.WriteLine(DiagonalDifference(arr));
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int sum = 0;
            int arrCount = arr.Count;

            for (int i = 0; i < arrCount; i++)
            {
                for (int j = 0; j < arrCount; j++)
                {
                    if (i == j)
                    {
                        sum += arr[i][j];
                    }
                    if (i + j == arrCount - 1)
                    {
                        sum -= arr[i][j];
                    }
                }
            }

            return Math.Abs(sum);
        }
    }
}
