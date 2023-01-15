using System;
using System.Transactions;

namespace AlgorithmCoding
{
    public class BestTimeToBuyAndSellStock
    {
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.
        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        //Input: prices = [7,1,5,3,6,4]
        //Output: 5

        public static int MaxProfit(int[] prices)
        {
            var min = int.MaxValue;
            var max = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else
                {
                    max = Math.Max(max, prices[i] - min);
                }
            }

            return max;
        }
    }
}
