namespace AlgorithmCoding
{
    public static class FirstBadVersion
    {
        // You are given an API bool isBadVersion(version) which returns whether version is bad.
        // Implement a function to find the first bad version. You should minimize the number of calls to the API.
        // 1 <= bad <= n <= 231 - 1

        public static int FirstBadVersionResult(int n)
        {
            var left = 1;
            var right = n;

            while (left < right)
            {
                var middle = (right - left) / 2 + left;
                if (IsBadVersion(middle))
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }

            }

            return left;
        }

        public static bool IsBadVersion(int k)
        {
            if (k == 5)
                return true;
            return false;
        }
    }
}
