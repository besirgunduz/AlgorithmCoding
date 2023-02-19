using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class TaskScheduler
    {
        //Given a characters array tasks, representing the tasks a CPU needs to do, where each letter represents a different task. Tasks could be done in any order. Each task is done in one unit of time. For each unit of time, the CPU could complete either one task or just be idle.
        //However, there is a non-negative integer n that represents the cooldown period between two same tasks(the same letter in the array), that is that there must be at least n units of time between any two same tasks.
        //Return the least number of units of times that the CPU will take to finish all the given tasks.

        //Input: tasks = ["A","A","A","A","A","A","B","C","D","E","F","G"], n = 2
        //Output: 16

        public static int LeastInterval(char[] tasks, int n)
        {
            var chars = new int[26];

            foreach (var task in tasks)
            {
                chars[task - 'A']++;
            }

            Array.Sort(chars);
            var max = chars[25] - 1;
            var idleCount = max * n;

            for (int i = 24; i >= 0; i--)
            {
                idleCount -= Math.Min(chars[i], max);
            }

            return idleCount > 0 ? idleCount + tasks.Length : tasks.Length;
        }
    }
}
