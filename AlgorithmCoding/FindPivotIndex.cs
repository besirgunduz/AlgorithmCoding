using System;
using System.Linq;
using System.Xml.Linq;

namespace AlgorithmCoding
{
    public class FindPivotIndex
    {
        //Given an array of integers nums, calculate the pivot index of this array.
        //The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.
        //If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left.This also applies to the right edge of the array.
        //Return the leftmost pivot index.If no such index exists, return -1.

        //Input: nums = [1,7,3,6,5,6]
        //Output: 3
        //Explanation:
        //The pivot index is 3.

        public static int PivotIndex(int[] nums)
        {
            var total = nums.Sum();
            var leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0)
                {
                    leftSum += nums[i - 1];
                }
                if (total - leftSum - nums[i] == leftSum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
