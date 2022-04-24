using System;

namespace AlgorithmCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = SingleElement.SingleNonDublicate(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 });
            Console.WriteLine(result);
        }
    }
}
