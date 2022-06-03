using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class Sqrt
    {
        //Given a non-negative integer x, compute and return the square root of x.
        //Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.
        //Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5)

        //Input: x = 8
        //Output: 2

        public static int SqrtResult(int x)
        {
            int left = 1;
            int right = x;

            while (right >= left)
            {
                int middle = (right - left) / 2 + left;

                if (x / middle == middle)
                    return middle;

                else if (x / middle < middle)
                    right = middle - 1;

                else
                    left = middle + 1;
            }

            return right;
        }
    }
}
