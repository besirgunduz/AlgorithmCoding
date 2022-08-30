namespace AlgorithmCoding
{
    public static class AddDigits
    {
        //Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

        //Input: num = 38
        //Output: 2
        //Explanation: The process is
        //38-- > 3 + 8-- > 11
        //11-- > 1 + 1-- > 2

        public static int AddDigitsResult(int num)
        {
            while (num >= 10)
            {
                num = DigitsSum(num);
            }
            return num;
        }

        public static int DigitsSum(int num)
        {
            var sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
