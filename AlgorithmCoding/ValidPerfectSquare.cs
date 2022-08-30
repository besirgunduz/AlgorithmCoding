namespace AlgorithmCoding
{
    public static class ValidPerfectSquare
    {
        //Given a positive integer num, write a function which returns True if num is a perfect square else False.
        //Follow up: Do not use any built -in library function such as sqrt.

        //Input: num = 16
        //Output: true

        public static bool IsPerfectSquare(int num)
        {
            long left = 1;
            long right = num;
            while (left <= right)
            {
                long middle = (right - left) / 2 + left;

                if (middle * middle == num) return true;
                if (middle * middle > num) right = middle - 1;
                else left = middle + 1;
            }

            return false;
        }

    }
}
