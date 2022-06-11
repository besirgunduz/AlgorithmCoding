using System.Collections.Generic;

namespace AlgorithmCoding
{
    public static class SumOfUniqueElements
    {
        //You are given an integer array nums.
        //The unique elements of an array are the elements that appear exactly once in the array.
        //Return the sum of all the unique elements of nums.

        //Input: nums = [1, 2, 3, 2]
        //Output: 4
        //Explanation: The unique elements are[1, 3], and the sum is 4.

        public static int SumOfUniqueResult(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            foreach (var key in dic.Keys)
            {
                if (dic[key] == 1)
                {
                    sum += key;
                }
            }

            return sum;
        }
    }
}
