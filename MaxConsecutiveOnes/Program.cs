using System;

namespace MaxConsecutiveOnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given a binary array nums, return the maximum number of consecutive 1's in the array.

            //Input: nums = [1, 1, 0, 1, 1, 1]
            //Output: 3

            var nums = new int[] { 1, 1, 0, 1, 1, 1 };
            Console.WriteLine(MaxConsecutiveOnes(nums));
        }

        private static int MaxConsecutiveOnes(int[] nums)
        {
            var max = 0;
            var curr = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    curr++;
                    max = Math.Max(max, curr);
                }
                else
                {
                    curr = 0;
                }

            }

            return max;
        }
    }
}
