using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class AlternatingBits
    {
        //Given a positive integer, check whether it has alternating bits: namely,
        //if two adjacent bits will always have different values.

        //Input: n = 5
        //Output: true
        //Explanation: The binary representation of 5 is: 101

        public static bool HasAlternatingBits(int n)
        {
            var binary = Convert.ToString(n, 2);

            for (int i = 0; i < binary.Length - 1; i++)
            {
                if (binary[i] == binary[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
