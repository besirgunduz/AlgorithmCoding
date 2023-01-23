using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class SortArrayByParity
    {
        //Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
        //Return any array that satisfies this condition.

        //Input: nums = [3,1,2,4]
        //Output: [2,4,3,1]

        public static int[] SortArrayByParityResult(int[] nums)
        {
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    var temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;
                    index++;
                }
            }

            return nums;
        }
    }
}
