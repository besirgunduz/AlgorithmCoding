using System;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a sorted array of distinct integers and a target value, return the index if the target is found.
            //If not, return the index where it would be if it were inserted in order.

            //Input: nums = [1,3,5,6], target = 5
            //Output: 2

            //Input: nums = [1,3,5,6], target = 2
            //Output: 1

            //Input: nums = [1,3,5,6], target = 7
            //Output: 4

            var nums = new int[] { 1, 2, 5, 6 };
            var target = 5;

            var index = SearchInsertPosition(nums, target);
            Console.WriteLine(index);

        }

        private static int SearchInsertPosition(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }

            return nums.Length;
        }
    }
}
