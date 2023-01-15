namespace AlgorithmCoding
{
    public class PowerOfTwo
    {
        // Given an integer, write a function to determine if it is a power of two.

        //Input: n = 16
        //Output: true

        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            while (n % 2 == 0)
            {
                n /= 2;
            }

            return n == 1;
        }

        public static bool IsPowerOfTwo2(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            if (n == int.MinValue)
            {
                return false;
            }

            return (n & (n - 1)) == 0;
        }
    }
}
