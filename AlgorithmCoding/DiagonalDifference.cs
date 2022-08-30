using System;
using System.Collections.Generic;

namespace AlgorithmCoding
{
    public static class DiagonalDifference
    {
        //Given a square matrix, calculate the absolute difference between the sums of its diagonals

        public static int DiagonalDifferenceResult(List<List<int>> arr)
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
