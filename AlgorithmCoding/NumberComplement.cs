using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class NumberComplement
    {
        //The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.
        //For example, The integer 5 is "101" in binary and its complement is "010" which is the integer 2.

        public static int NumberComplementResult(int num)
        {
            var bigNumber = 1;

            while (num > bigNumber)
            {
                bigNumber <<= 1;
                bigNumber++;
            }

            return bigNumber - num;
        }
    }
}
