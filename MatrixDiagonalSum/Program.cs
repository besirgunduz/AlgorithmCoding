namespace MatrixDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a square matrix mat, return the sum of the matrix diagonals.
            //Only include the sum of all the elements on the primary diagonal and
            //all the elements on the secondary diagonal that are not part of the primary diagonal.

            //        Input: mat = [[1,2,3],
            //                      [4,5,6],
            //                      [7,8,9]]
            //Output: 25
            //Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
            //Notice that element mat[1][1] = 5 is counted only once.
        }

        public static int DiagonalSum(int[][] mat)
        {
            var sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (i == j || i + j == mat[i].Length - 1)
                    {
                        sum += mat[i][j];
                    }
                }
            }
            return sum;
        }
    }
}