﻿namespace AlgorithmCoding
{
    public class ReverseString
    {
        //Write a function that reverses a string. The input string is given as an array of characters s.
        //You must do this by modifying the input array in-place with O(1) extra memory.

        //Input: s = ["h","e","l","l","o"]
        //Output: ["o","l","l","e","h"]

        public static char[] ReverseStringResult(char[] s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }

            return s;

        }
    }
}
