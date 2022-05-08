using System;

namespace AlgorithmCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");

            var arraySort = ArraySort.ArraySortResult(new int[] { 3, 2, 1 });

            Console.WriteLine(string.Join(',', arraySort));
        }
    }
}
