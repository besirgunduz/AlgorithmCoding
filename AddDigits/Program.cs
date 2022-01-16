using System;

namespace AddDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

            //Input: num = 38
            //Output: 2
            //Explanation: The process is
            //38-- > 3 + 8-- > 11
            //11-- > 1 + 1-- > 2

            Console.WriteLine(AddDigits(38));
        }

        private static int AddDigits(int num)
        {
            while (num >= 10)
            {
                num = DigitsSum(num);
            }
            return num;
        }

        private static int DigitsSum(int num)
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
