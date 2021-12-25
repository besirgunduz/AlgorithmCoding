using System;

namespace NumberOfGoodPairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers nums, return the number of good pairs.
            //A pair(i, j) is called good if nums[i] == nums[j] and i<j.

            //1 <= nums.length <= 100
            //1 <= nums[i] <= 100

            //Input: nums = [1, 2, 3, 1, 1, 3]
            //Output: 4

            //Input: nums = [1, 1, 1, 1]
            //Output: 6

            var nums = new int[] { 1, 2, 3, 1, 1, 3 };
            Console.WriteLine(NumIdenticalPairs(nums));
            Console.WriteLine(NumIdenticalPairs2(nums));
        }
        //solution 1
        private static int NumIdenticalPairs(int[] nums)
        {
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        //solution 1
        private static int NumIdenticalPairs2(int[] nums)
        {
            var sum = 0;
            var arr = new int[101];

            foreach (var i in nums)
            {
                sum += arr[i]++;
            }

            return sum;
        }
    }
}
