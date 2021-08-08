using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an integer array nums sorted in non - decreasing order, remove the duplicates in-place such that each unique element appears only once. 
            //The relative order of the elements should be kept the same.

            //Input: nums = [1,1,2]
            //Output: 2, nums = [1, 2, _]

            //Input: nums = [0,0,1,1,1,2,2,3,3,4]
            //Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]

            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(nums));


        }

        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            var mevcutKarakter = nums[0];
            var index = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != mevcutKarakter)
                {
                    index++;
                    mevcutKarakter = nums[i];
                    nums[index] = mevcutKarakter;
                }
            }

            return index + 1; // + 1 = mevcutKarakter
        }
    }
}
