using System.Collections.Generic;
using System.Linq;

namespace AlgorithmCoding
{
    public class ContainsDuplicate
    {
        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        //Input: nums = [1,2,3,1]
        //Output: true

        public static bool ContainsDuplicateResult(int[] nums)
        {
            var result = nums.GroupBy(x => x)
                .Where(y => y.Count() > 1)
                .Count() > 0;

            return result;
        }

        //result2
        public static bool ContainsDuplicateResult2(int[] nums)
        {
            var set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!set.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
