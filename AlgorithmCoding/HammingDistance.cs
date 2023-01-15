namespace AlgorithmCoding
{
    public class HammingDistance
    {
        //The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
        //Given two integers x and y, return the Hamming distance between them.

        //Input: x = 1, y = 4
        //Output: 2
        //Explanation:
        //1   (0 0 0 1)
        //4   (0 1 0 0)
        //The above arrows point to positions where the corresponding bits are different.

        public static int HammingDistanceResult(int x, int y)
        {
            var counter = 0;

            while (x > 0 || y > 0)
            {
                counter += (x % 2) ^ (y % 2);

                x >>= 1;
                y >>= 1;
            }

            return counter;
        }
    }
}
