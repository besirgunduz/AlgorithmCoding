using System;
using System.Text;

namespace SmallerNumbersThanCurrent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given the array nums, for each nums[i] find out how many numbers
            //in the array are smaller than it.That is, for each nums[i] you have
            //to count the number of valid j's such that j != i and nums[j] < nums[i].
            //0 <= nums[i] <= 100

            //Input: nums = [8, 1, 2, 2, 3]
            //Output:[4,0,1,1,3]

            var nums = new int[] { 8, 1, 2, 2, 3 };
            Console.WriteLine(SmallerNumbersThanCurrent(nums));
            Console.ReadKey();


        }

        private static string SmallerNumbersThanCurrent(int[] nums)
        {
            var count = new int[101];
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++; //count[8]=1
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = count[nums[i] - 1];
                }
            }

            var sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.Append(item);
                sb.Append(' ');
            }

            return sb.ToString();
        }
    }
}
