using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class CountNegatives
    {
        //Given a m x n matrix grid which is sorted in non - increasing order both row - wise and column-wise,
        //return the number of negative numbers in grid.

        //Input: grid = [[4, 3, 2, -1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
        //Output: 8
        //Explanation: There are 8 negatives number in the matrix.

        public static int CountNegativesResult(int[][] grid)
        {
            var row = grid.Length - 1;
            var column = 0;
            var totalColumn = grid[0].Length;
            var count = 0;

            while (row >= 0 && column < totalColumn)
            {
                if (grid[row][column] < 0)
                {
                    count += totalColumn - column;
                    row--;
                }
                else
                {
                    column++;
                }
            }

            return count;
        }
    }
}
