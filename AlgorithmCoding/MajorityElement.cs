using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class MajorityElement
    {
        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.

        //Input: nums = [2,2,1,1,1,2,2]
        //Output: 2

        public static int MajorityElementResult(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var dic = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            var halfSize = nums.Length / 2;

            foreach (var key in dic.Keys)
            {
                if (dic[key] > halfSize)
                {
                    return key;
                }
            }

            return -1;
        }
    }
}
