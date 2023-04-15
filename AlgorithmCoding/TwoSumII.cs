using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;
namespace AlgorithmCoding
{
    public class TwoSumII
    {
        //Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order,
        //find two numbers such that they add up to a specific target number.Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1<index2 <= numbers.length.
        //Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
        //The tests are generated such that there is exactly one solution.You may not use the same element twice.
        //Your solution must use only constant extra space.

        //Input: numbers = [2,7,11,15], target = 9
        //Output: [1,2]
        //Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].

        public static int[] TwoSumIIResult(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;

            while (start <= end)
            {
                var sum = nums[start] + nums[end];

                if (sum > target)
                {
                    end--;
                }
                else if (sum < target)
                {
                    start++;
                }
                else
                {
                    return new int[] { start, end };
                }
            }

            return new int[] { start, end };
        }
    }
}
