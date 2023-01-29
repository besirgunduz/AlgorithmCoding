using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmCoding
{
    public class LicenseKeyFormatting
    {
        //You are given a license key represented as a string s that consists of only alphanumeric characters and dashes.
        //The string is separated into n + 1 groups by n dashes. You are also given an integer k.

        //We want to reformat the string s such that each group contains exactly k characters,
        //except for the first group, which could be shorter than k but still must contain at least one character.Furthermore,
        //there must be a dash inserted between two groups, and you should convert all lowercase letters to uppercase.
        //Return the reformatted license key.

        //Input: s = "5F3Z-2e-9-w", k = 4
        //Output: "5F3Z-2E9W"

        //Input: s = "2-5g-3-J", k = 2
        //Output: "2-5G-3J"

        public static string LicenseKeyFormattingResult(string S, int K)
        {
            var sb = new StringBuilder();
            var counter = 0;

            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '-')
                    continue;

                if (counter == K)
                {
                    sb.Append('-');
                    counter = 0;
                }

                sb.Append(char.ToUpper(S[i]));
                counter++;
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
