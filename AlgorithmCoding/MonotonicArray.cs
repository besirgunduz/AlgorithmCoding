namespace AlgorithmCoding
{
    public class MonotonicArray
    {
        //An array is monotonic if it is either monotone increasing or monotone decreasing.
        //An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].
        //Given an integer array nums, return true if the given array is monotonic, or false otherwise.

        //Input: nums = [6,5,4,4]
        //Output: true
        //1 3 2
        public static bool IsMonotonic(int[] nums)
        {
            var inc = true;
            var dec = true;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    dec = false;
                }

                if (nums[i] > nums[i + 1])
                {
                    inc = false;
                }
            }

            return inc || dec;
        }
    }
}
