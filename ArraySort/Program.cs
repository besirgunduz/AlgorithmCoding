using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 3,5,55959,6,3,9,77,22,1,8,999, 12, 1, 7 };
            int temp;

            for (int i = 0; i < sayilar.Length-1; i++)
            {
                for (int j = i+1; j < sayilar.Length; j++)
                {
                    if (sayilar[i] > sayilar[j])
                    {
                        temp = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = temp;
                    }
                }
            }

            foreach (var item in sayilar)
            {
                Console.Write(item+" ");
            }

        }
    }
}
