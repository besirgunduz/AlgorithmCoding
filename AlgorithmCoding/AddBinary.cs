using System;
using System.Linq;
using System.Text;

namespace AlgorithmCoding
{
    public static class AddBinary
    {
        //Given two binary strings a and b, return their sum as a binary string.

        //Input: a = "11", b = "1"
        //Output: "100"

        //Input: a = "1010", b = "1011"
        //Output: "10101"

        public static string AddBinaryResult(string a, string b)
        {
            //toplamaya son indexten başla
            var aIndex = a.Length - 1;
            var bIndex = b.Length - 1;

            var elde = 0;
            var sb = new StringBuilder();

            while (aIndex >= 0 || bIndex >= 0)
            {
                var total = elde;

                if (aIndex >= 0)
                {
                    total += a[aIndex] - '0'; //int olarak toplamak için
                }

                if (bIndex >= 0)
                {
                    total += b[bIndex] - '0';
                }

                sb.Append(total % 2);
                elde = total / 2;

                aIndex--;
                bIndex--;
            }

            if (elde > 0)
            {
                sb.Append(elde);
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
