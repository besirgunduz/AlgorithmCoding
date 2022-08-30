using System;
using System.Collections.Generic;

namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an array nums of size n, return the majority element.
            //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.

            //Input: nums = [2,2,1,1,1,2,2]
            //Output: 2

            Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }
        public static int MajorityElement(int[] nums)
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

            foreach (var key in dic.Keys)
            {
                if (dic[key] > nums.Length / 2)
                {
                    return key;
                }
            }

            return -1;
        }
    }
}
