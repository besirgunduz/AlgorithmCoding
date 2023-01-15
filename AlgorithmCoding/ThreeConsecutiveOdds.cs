namespace AlgorithmCoding
{
    public class ThreeConsecutiveOdds
    {
        //Given an integer array arr, return true if there are three consecutive odd numbers in the array. Otherwise, return false.

        //Input: arr = [1, 2, 34, 3, 4, 5, 7, 23, 12]
        //Output: true
        //Explanation:[5,7,23] are three consecutive odds.

        public static bool ThreeConsecutiveOddsResult(int[] arr)
        {
            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count = 0;
                }
                else
                {
                    count++;

                    if (count == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
