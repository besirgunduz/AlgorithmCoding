namespace AlgorithmCoding
{
    public class RotateImage
    {
        public static int[,] Rotate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            var result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[cols - j - 1, i] = matrix[i, j];
                }
            }

            return result;
        }
    }
}
