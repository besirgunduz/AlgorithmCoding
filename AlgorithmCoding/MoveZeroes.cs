namespace AlgorithmCoding
{
    public class MoveZeroes
    {
        //Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        //Note that you must do this in-place without making a copy of the array.

        //Input: nums = [0, 1, 0, 3, 12]
        //Output:[1,3,12,0,0]
        public static int[] MoveZeroesResult(int[] nums)
        {
            var index = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
