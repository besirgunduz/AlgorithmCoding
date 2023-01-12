using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class AddStrings
    {
        //Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.
        //You must solve the problem without using any built-in library for handling large integers (such as BigInteger).
        //You must also not convert the inputs to integers directly.

        //Input: num1 = "456", num2 = "77"
        //Output: "533"

        public static string AddStringResult(string num1, string num2)
        {
            var i = num1.Length - 1;
            var j = num2.Length - 1;

            var sb = new StringBuilder();

            var elde = 0;

            while (i >= 0 || j >= 0)
            {
                var sum = elde;

                if (i >= 0)
                {
                    sum += num1[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += num2[j] - '0';
                    j--;
                }

                sb.Append(sum % 10);
                elde = sum / 10;
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
