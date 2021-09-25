using System;
using System.Text;

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input: n = 4
            //Output: "1211"
            //Explanation:
            //countAndSay(1) = "1"
            //countAndSay(2) = say "1" = one 1 = "11"
            //countAndSay(3) = say "11" = two 1's = "21"
            //countAndSay(4) = say "21" = one 2 + one 1 = "12" + "11" = "1211"

            Console.WriteLine(CountAndSay(45));
        }

        private static string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }

            var result = "1"; //21

            while (n > 1)
            {
                var sb = new StringBuilder();

                for (int i = 0; i < result.Length; i++)
                {
                    var counter = 1;

                    while (i + 1 < result.Length && result[i] == result[i + 1])
                    {
                        counter++;
                        i++;
                    }

                    sb.Append(counter).Append(result[i]); // 11 - 21 - 1211
                }

                result = sb.ToString(); //11 - 21
                n--;
            }

            return result;
        }
    }
}
