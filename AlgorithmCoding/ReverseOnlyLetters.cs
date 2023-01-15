using System.Collections.Generic;
using System.Text;

namespace AlgorithmCoding
{
    public class ReverseOnlyLetters
    {
        // Given a string s, reverse the string according to the following rules:
        //All the characters that are not English letters remain in the same position.
        //All the English letters(lowercase or uppercase) should be reversed.
        //Return s after reversing it.

        //Input: s = "a-bC-dEf-ghIj"
        //Output: "j-Ih-gfE-dCba"
        public static string ReverseOnlyLettersResult(string s)
        {
            var stack = new Stack<char>();
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
