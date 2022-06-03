using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class MissingNumber
    {
        //Given an array nums containing n distinct numbers in the range[0, n],
        //return the only number in the range that is missing from the array.

        //Input: nums = [9, 6, 4, 2, 3, 5, 7, 0, 1]
        //Output: 8

        public static int MissingNumberResult(int[] nums)
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
