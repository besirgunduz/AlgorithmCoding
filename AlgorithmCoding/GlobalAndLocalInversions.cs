using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class GlobalAndLocalInversions
    {
        //You are given an integer array nums of length n which represents a permutation of all the integers in the range [0, n - 1].

        //The number of global inversions is the number of the different pairs(i, j) where:
        //0 <= i<j<n
        //nums[i]> nums[j]

        //The number of local inversions is the number of indices i where:
        //0 <= i<n - 1
        //nums[i]> nums[i + 1]

        //Return true if the number of global inversions is equal to the number of local inversions.

        //Input: nums = [1,2,0]
        //Output: false

        public static bool IsIdealPermutation(int[] nums)
        {
            var max = -1;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                max = Math.Max(nums[i], max);

                if (max > nums[i + 2])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
