using System;
using System.Linq;

namespace AlgorithmCoding
{
    public class ThirdMaximumNumber
    {
        //Given an integer array nums, return the third distinct maximum number in this array.
        //If the third maximum does not exist, return the maximum number.

        //Input: nums = [2,2,3,1]
        //Output: 1
        //Explanation:
        //The first distinct maximum is 3.
        //The second distinct maximum is 2 (both 2's are counted together since they have the same value).
        //The third distinct maximum is 1.

        public static int ThirdMaximumNumberResult(int[] nums)
        {
            Array.Sort(nums);
            var numsList = nums.Distinct().ToList();


            if (numsList.Count >= 3)
            {
                return numsList[numsList.Count - 3];
            }
            else
            {
                return numsList.Max();
            }
        }
    }
}
