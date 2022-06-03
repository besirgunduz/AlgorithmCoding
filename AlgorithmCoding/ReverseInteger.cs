using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class ReverseInteger
    {
        //Given a signed 32-bit integer x, return x with its digits reversed.
        //If reversing x causes the value to go outside the signed 32-bit integer range[-231, 231 - 1], then return 0.

        //Example:

        //Input: x = 123
        //Output: 321

        //Input: x = -123
        //Output: -321

        //Input: x = 120
        //Output: 21

        //Input: x = 0
        //Output: 0

        public static int ReverseIntegerResult(int x)
        {
            var isNegative = x < 0;

            if (isNegative)
            {
                x = -x;
            }

            long reverse = 0;

            while (x > 0)
            {
                reverse = (x % 10) + (reverse * 10);
                x /= 10;
            }

            if (reverse > int.MaxValue)
            {
                return 0;
            }

            return isNegative ? (int)(reverse * -1) : (int)reverse;
        }
    }
}
