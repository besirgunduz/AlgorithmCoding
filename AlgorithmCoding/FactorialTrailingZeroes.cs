namespace AlgorithmCoding
{
    public static class FactorialTrailingZeroes
    {
        //Given an integer n, return the number of trailing zeroes in n!.

        //Input: n = 5
        //Output: 1
        //Explanation: 5! = 120, one trailing zero.

        public static int TrailingZeroes(int n)
        {
            var counter = 0;

            while (n > 0)
            {
                n /= 5;
                counter += n;
            }

            return counter;
        }
    }
}
