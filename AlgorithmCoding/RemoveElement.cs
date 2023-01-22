using System.Collections.Generic;
using System.Xml.Linq;

namespace AlgorithmCoding
{
    public class RemoveElement
    {
        //Input: nums = [3,2,2,3], val = 3
        //Output: 2, nums = [2,2, _, _]
        //Explanation: Your function should return k = 2, with the first two elements of nums being 2.
        //It does not matter what you leave beyond the returned k(hence they are underscores).
        public static int RemoveElementResult(int[] nums, int val)
        {
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}
