using System;

namespace ThousandSeparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Given an integer n, add a dot(".") as the thousands separator and return it in string format.

            //Input: n = 987
            //Output: "987"

            //Input: n = 1234
            //Output: "1.234"

            var n = 123435;
            Console.WriteLine(ThousandSeparator(n));
        }

        private static string ThousandSeparator(int n)
        {
            if (n < 1000)
            {
                return n.ToString();
            }

            var result = string.Empty;
            var count = 0;

            while (n > 0)
            {
                if (count % 3 == 0 && count > 0)
                {
                    result = '.' + result;
                }

                count++;
                result = n % 10 + result;
                n /= 10;
            }

            return result;

        }
    }
}
