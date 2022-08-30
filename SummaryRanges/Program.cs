using System.Collections.Generic;

namespace SummaryRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given a sorted unique integer array nums.
            //Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
            //That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

            //Input: nums = [0, 1, 2, 4, 5, 7]
            //Output:["0->2","4->5","7"]
            //Explanation: The ranges are:
            //[0,2] --> "0->2"
            //[4, 5]-- > "4->5"
            //[7, 7]-- > "7"

            var nums = new int[] { 0, 1, 2, 4, 5, 7 };
            SummaryRanges(nums);
        }

        private static IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();
            var start = 0;
            var end = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                while (i < nums.Length - 1 && nums[i] + 1 == nums[i + 1])
                {
                    end++;
                    i++;
                }

                if (start == end)
                {
                    result.Add(nums[start].ToString());
                }
                else
                {
                    result.Add($"{nums[start]}->{nums[end]}");
                }

                end++;
                start = end;
            }

            return result;
        }
    }
}
