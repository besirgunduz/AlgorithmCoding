using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            //answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
            //answer[i] == "Fizz" if i is divisible by 3.
            //answer[i] == "Buzz" if i is divisible by 5.
            //answer[i] == i(as a string) if none of the above conditions are true.

            //Input: n = 15
            //Output:["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]

            Console.WriteLine(FizzBuzz(15));
        }
        private static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
