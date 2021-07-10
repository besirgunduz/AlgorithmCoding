using System;
using System.Collections;
using System.Collections.Generic;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            // An input string is valid if:

            // Open brackets must be closed by the same type of brackets.
            // Open brackets must be closed in the correct order.


            String s = "(){}[]";

            Console.WriteLine(ValidParentheses(s));

        }

        private static bool ValidParentheses(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char mevcutKarakter = s[i];

                if (mevcutKarakter == '(')
                {
                    stack.Push(')');
                }
                else if (mevcutKarakter == '{')
                {
                    stack.Push('}');
                }
                else if (mevcutKarakter == '[')
                {
                    stack.Push(']');
                }
                else if (stack.Count == 0 || stack.Pop() != mevcutKarakter)
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
