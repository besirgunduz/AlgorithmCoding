﻿using System.Collections.Generic;

namespace AlgorithmCoding
{
    public class TwoSum
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //Example:

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output:[0,1]
        //Output: Because nums[0] +nums[1] == 9, we return [0, 1]

        public static int[] TwoSumResult(int[] nums, int target)
        {
            int[] arr = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        break;
                    }
                }
            }

            return arr;
        }

        public static int[] TwoSumResult2(int[] nums, int target)
        {
            int[] arr = new int[2];

            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (dic.ContainsKey(difference))
                {
                    arr[0] = dic[difference];
                    arr[1] = i;
                    break;
                }

                dic[nums[i]] = i;
            }

            return arr;
        }

        public static int[] TwoSumResult3(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;

            while (start <= end)
            {
                var sum = nums[start] + nums[end];

                if (sum > target)
                {
                    end--;
                }
                else if (sum < target)
                {
                    start++;
                }
                else
                {
                    return new int[] { start, end };
                }
            }

            return new int[] { start, end };
        }

    }
}
