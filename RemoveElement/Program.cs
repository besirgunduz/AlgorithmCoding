using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.

            //Input: nums = [3, 2, 2, 3], val = 3
            //Output: 2, nums = [2, 2, _, _]

            //Input: nums = [0,1,2,2,3,0,4,2], val = 2
            //Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]

            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var val = 2;
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            Console.WriteLine(index);
        }
    }
}
