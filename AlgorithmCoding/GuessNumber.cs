namespace AlgorithmCoding
{
    /// <summary>
    /// Tahmin Oyunu
    /// </summary>
    public class GuessNumber
    {
        public static int GuessNumberResult(int n, int pick)
        {
            int left = 1;
            int right = n;

            while (left <= right)
            {
                int middle = (right - left) / 2 + left;

                if (middle == pick)
                {
                    return middle;
                }
                else if (middle < pick)
                {
                    left = middle + 1;

                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }

    }

}
