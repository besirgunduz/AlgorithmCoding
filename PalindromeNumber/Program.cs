using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.

            Console.WriteLine(IsPalindrome(123));
        }

        private static bool IsPalindrome(int x)
        {
            var tempX = x;

            var reverse = 0;

            while (x > 0)
            {
                reverse = (x % 10) + (reverse * 10);
                x /= 10;
            }

            if (reverse == tempX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
