using System;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Merge nums1 and nums2 into a single array sorted in non-decreasing order.

            //Input: nums1 = [1, 2, 3], m = 3, nums2 = [2, 5, 6], n = 3
            //Output:[1,2,2,3,5,6]

            int[] nums1 = new int[] { 1, 2, 3 };
            int m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;

            foreach (var item in MergeSortedArray(nums1, m, nums2, n))
            {
                Console.Write($"{item} ");
            }

        }

        private static int[] MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            int[] newNums = new int[m + n];
            int k = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                newNums[i] = nums1[i];
            }

            for (int j = m; j < newNums.Length; j++, k++)
            {
                newNums[j] = nums2[k];
            }

            Array.Sort(newNums);
            return newNums;
        }
    }
}
