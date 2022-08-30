using System.Collections.Generic;

namespace SetMatrixZeroes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Given an m x n integer matrix matrix, if an element is 0,
            //set its entire row and column to 0's, and return the matrix.

            //Input: [[1, 1, 1],
            //        [1, 0, 1],
            //        [1, 1, 1]]

            //Output:[[1,0,1],
            //        [0,0,0],
            //        [1,0,1]]
        }

        private void SetZeroes(int[][] matrix)
        {
            var row = matrix.Length;
            var column = matrix[0].Length;

            var rowSet = new HashSet<int>();
            var columnSet = new HashSet<int>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowSet.Add(i);
                        columnSet.Add(j);
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (rowSet.Contains(i) || columnSet.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
