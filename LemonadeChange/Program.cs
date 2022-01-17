using System;

namespace LemonadeChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //At a lemonade stand, each lemonade costs $5.
            //Customers are standing in a queue to buy from you and order one at a time(in the order specified by bills).
            //Each customer will only buy one lemonade and pay with either a $5, $10, or $20 bill.
            //You must provide the correct change to each customer so that the net transaction is that the customer pays $5.

            //Input: bills = [5, 5, 5, 10, 20]
            //Output: true

            var bills = new int[] { 5, 5, 5, 10, 20 };

            Console.WriteLine(LemonadeChange(bills));
        }

        private static bool LemonadeChange(int[] bills)
        {
            var fiveCount = 0;
            var tenCount = 0;

            foreach (var item in bills)
            {
                if (item == 5)
                {
                    fiveCount++;
                }
                else if (item == 10)
                {
                    tenCount++;
                    fiveCount--;
                }
                else if (tenCount > 0)
                {
                    tenCount--;
                    fiveCount--;
                }
                else
                {
                    fiveCount -= 3;
                }

                if (fiveCount < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
