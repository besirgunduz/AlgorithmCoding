using System;

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
            int target = 8;

            int[] arr = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i]+nums[j]==target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                    }
                }
            }

            Console.WriteLine($"[{arr[0]},{arr[1]}]");

            Console.ReadKey();




        }
    }
}
