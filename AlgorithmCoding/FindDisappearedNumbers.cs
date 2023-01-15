using System;
using System.Collections.Generic;

namespace AlgorithmCoding
{
    public class FindDisappearedNumbers
    {
        //Given an array nums of n integers where nums[i] is in the range[1, n],
        //return an array of all the integers in the range[1, n] that do not appear in nums.

        //Input: nums = [4, 3, 2, 7, 8, 2, 3, 1]
        //Output:[5,6]

        public static IList<int> FindDisappearedNumbersResult(int[] nums)
        {
            var result = new List<int>();
            Array.Sort(nums);
            int max = nums.Length;

            for (int i = 0; i <= max; i++)
            {
                result.Add(i);
            }

            foreach (var i in nums)
            {
                result[i] = -1;
            }

            result.RemoveAll(x => x == -1);
            result.RemoveAt(0);
            return result;
        }
    }
}
