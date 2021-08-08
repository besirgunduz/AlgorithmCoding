using System;

namespace ImplementIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
            // For the purpose of this problem, we will return 0 when needle is an empty string. 

            // Input: haystack = "hello", needle = "ll"
            // Output: 2

            //Input: haystack = "aaaaa", needle = "bba"
            //Output: -1

            //Input: haystack = "", needle = ""
            //Output: 0

            string haystack = "hello";
            string needle = "ll";

            Console.WriteLine(ImplementIndexOf(haystack, needle));

            Console.ReadKey();

        }

        static int ImplementIndexOf(string haystack, string needle)
        {
            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            return haystack.IndexOf(needle);
        }
    }
}
