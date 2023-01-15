namespace AlgorithmCoding
{
    public class CanPlaceFlowers
    {
        //You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
        //Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, 
        //return if n new flowers can be planted in the flowerbed without violating the no-adjacent - flowers rule.

        //Input: flowerbed = [1, 0, 0, 0, 1], n = 1
        //Output: true

        public static bool CanPlaceFlowersResult(int[] flowerbed, int n)
        {
            var count = 0;

            for (int i = 0; i < flowerbed.Length && count < n; i++)
            {
                if (flowerbed[i] == 0)
                {
                    var previous = (i == 0) ? flowerbed[i] : flowerbed[i - 1];
                    var next = (i == flowerbed.Length - 1) ? flowerbed[i] : flowerbed[i + 1];

                    if (previous == 0 && next == 0)
                    {
                        flowerbed[i] = 1;
                        count++;
                    }
                }
            }

            return count == n;

        }
    }
}
