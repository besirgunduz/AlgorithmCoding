using System;
using System.Collections;
using System.Text;

namespace ReverseOnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string s, reverse the string according to the following rules:
            //All the characters that are not English letters remain in the same position.
            //All the English letters(lowercase or uppercase) should be reversed.

            //Input: s = "ab-cd"
            //Output: "dc-ba"

            //Input: s = "a-bC-dEf-ghIj"
            //Output: "j-Ih-gfE-dCba"

            //Input: s = "Test1ng-Leet=code-Q!"
            //Output: "Qedo1ct-eeLg=ntse-T!"

            Console.WriteLine(ReverseOnlyLetters("Test1ng-Leet=code-Q!"));

        }

        public static string ReverseOnlyLetters(string s)
        {
            var stack = new Stack();
            var sb = new StringBuilder();

            foreach (var item in s)
            {
                if (char.IsLetter(item))
                {
                    stack.Push(item);
                }
            }

            foreach (var item in s)
            {
                if (char.IsLetter(item))
                {
                    sb.Append(stack.Pop());
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
    }
}
