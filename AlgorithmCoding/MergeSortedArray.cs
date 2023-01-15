using System;

namespace AlgorithmCoding
{
    public class MergeSortedArray
    {
        public static int[] MergeSortedArrayResult(int[] nums1, int m, int[] nums2, int n)
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
