using System;

namespace SortArrayByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
            //Return any array that satisfies this condition.

            //Input: nums = [3, 1, 2, 4]
            //Output:[2,4,3,1] or [4,2,3,1] or [2,4,1,3] or [4,2,1,3]

            var nums = new int[] { 3, 1, 2, 4 };
            SortArrayByParity(nums);
        }

        private static int[] SortArrayByParity(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] % 2 == 0)
                    {
                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
