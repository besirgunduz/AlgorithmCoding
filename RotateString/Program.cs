using System;

namespace RotateString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.
            //A shift on s consists of moving the leftmost character of s to the rightmost position.
            //For example, if s = "abcde", then it will be "bcdea" after one shift.

            //Input: s = "abcde", goal = "cdeab"
            //Output: true

            var s = "abcde";
            var goal = "cdeab";

            Console.WriteLine(RotateString(s,goal));
        }

        private static bool RotateString(string s, string goal)
        {
            var str = s + s;

            return s.Length == goal.Length && str.Contains(goal);
        }
    }
}
//abcdeabcde