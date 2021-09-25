using System;
using System.Linq;
using System.Text;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given two binary strings a and b, return their sum as a binary string.

            //Input: a = "11", b = "1"
            //Output: "100"

            //Input: a = "1010", b = "1011"
            //Output: "10101"

            Console.WriteLine(AddBinary("1010", "1011"));
        }

        private static string AddBinary(string a, string b)
        {
            //toplamaya son indexten başlayacam
            var aIndex = a.Length - 1;
            var bIndex = b.Length - 1;

            var elde = 0;
            var sb = new StringBuilder();

            while (aIndex >= 0 || bIndex >= 0)
            {
                var total = elde;

                if (aIndex >= 0)
                {
                    total += a[aIndex] - '0'; //int olarak toplamak için bunu yaptım.
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
