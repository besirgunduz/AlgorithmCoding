using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            //Example:

            //Input: nums = [2, 7, 11, 15], target = 9
            //Output:[0,1]
            //Output: Because nums[0] +nums[1] == 9, we return [0, 1]

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            //1.yol
            var result = TwoSum(nums, target);
            Console.WriteLine($"[{result[0]},{result[1]}]");

            //2.yol
            var result2 = TwoSum2(nums, target);
            Console.WriteLine($"[{result2[0]},{result2[1]}]");

            Console.ReadKey();
        }

        private static int[] TwoSum(int[] nums, int target)
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
        private static int[] TwoSum2(int[] nums, int target)
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


    }
}
