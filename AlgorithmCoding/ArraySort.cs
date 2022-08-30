namespace AlgorithmCoding
{
    public static class ArraySort
    {
        public static int[] ArraySortResult(int[] nums)
        {
            int temp;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
