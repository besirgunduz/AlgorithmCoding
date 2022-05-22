using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class ValidParentheses
    {
        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        // An input string is valid if:

        // Open brackets must be closed by the same type of brackets.
        // Open brackets must be closed in the correct order.

        public static bool ValidParenthesesResult(string s)
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
