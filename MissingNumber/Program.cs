using System;

namespace MissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an array nums containing n distinct numbers in the range[0, n],
            //return the only number in the range that is missing from the array.

            //Input: nums = [9, 6, 4, 2, 3, 5, 7, 0, 1]
            //Output: 8
            var nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(MissingNumber(nums));
        }

        private static int MissingNumber(int[] nums)
        {
            var total = 0;
            var lenght = nums.Length;

            for (int i = 0; i < lenght; i++)
            {
                total += nums[i];
            }

            return (lenght * (lenght + 1)) / 2 - total;
        }
    }
}
