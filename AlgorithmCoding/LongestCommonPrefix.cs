namespace AlgorithmCoding
{
    public class LongestCommonPrefix
    {
        //Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".

        //Input: strs = ["flower","flow","flight"]
        //Output: "fl"

        public static string LongestCommonPrefixResult(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            var prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix[..^1]; //prefix.Substring(0, prefix.Length - 1)
                }
            }

            return prefix;
        }

    }
}
