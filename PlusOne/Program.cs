using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a non - empty array of decimal digits representing a non - negative integer, increment one to the integer.
            //The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.
            //You may assume the integer does not contain any leading zero, except the number 0 itself.

            //Input: digits = [1, 2, 3]
            //Output:[1,2,4]

            //Input: digits = [9, 9, 9]
            //Output:[1, 0, 0, 0]

            int[] digits = new int[] { 1, 2, 9 };

            foreach (var item in PlusOne(digits))
            {
                Console.Write($"{item} ");
            }
        }

        private static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;

            return newDigits;
        }
    }
}
