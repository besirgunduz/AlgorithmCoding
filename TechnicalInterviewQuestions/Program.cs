using System;
using System.Collections.Generic;

namespace TechnicalInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Soru
            //Cozum1();

            //2.Soru
            //Cozum2("abccddbeea", 0);
        }

        private static void Cozum1()
        {
            var list = new List<int>();
            var random = new Random();
            var count = 0;

            while (list.Count < 9)
            {
                var sayi = random.Next(1, 10);

                if (!list.Contains(sayi))
                    list.Add(sayi);

                count++;
            }

            Console.WriteLine($"Random fonksiyonu {count} kere çalışmıştır");
        }


        public static string Cozum2(string metin, int count)
        {
            if (metin.Length == 0)
            {
                return "";
            }

            var tempMetin = metin;
            var tempMetin2 = string.Empty;

            var anaMetinIndex = 0;

            var altMetin = tempMetin.Substring(1, tempMetin.Length - 1);
            var altMetinIndex = altMetin.IndexOf(tempMetin[0]);

            anaMetinIndex += altMetinIndex + 1;

            tempMetin = metin.Substring(1, altMetinIndex);
            tempMetin2 = metin.Substring(anaMetinIndex + 1, metin.Length - anaMetinIndex - 1);

            for (var i = 0; i < count; i++)
            {
                Console.Write("-");
            }

            Console.Write(metin[anaMetinIndex]);
            Console.WriteLine();

            count = count + 1;

            return Cozum2(tempMetin, count) + Cozum2(tempMetin2, count - 1);
        }
    }
}
