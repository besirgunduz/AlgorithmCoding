using System.Collections.Generic;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an integer numRows, return the first numRows of Pascal's triangle.
            //In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
            //Input: numRows = 5
            //Output:[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

            int numRows = 5;
            Generate(numRows);
        }

        private static IList<IList<int>> Generate(int numRows)
        {
            var ucgen = new List<IList<int>>();

            if (numRows == 0)
            {
                return ucgen;
            }

            //başlangıçta 1 satırı kendimiz oluşturduk ve 1 ekledik.
            var ilkSatir = new List<int>();
            ilkSatir.Add(1);
            ucgen.Add(ilkSatir);

            for (int i = 1; i < numRows; i++)
            {
                var oncekiSatir = ucgen[i - 1];

                //mevcut satırın ilk elemanı 1 eklendi
                var mevcutSatir = new List<int>();
                mevcutSatir.Add(1);

                //aradaki elemanlar
                for (int j = 1; j < i; j++)
                {
                    mevcutSatir.Add(oncekiSatir[j] + oncekiSatir[j - 1]);
                }
                //mevcut satıra son eleman olarak 1 eklendi 
                mevcutSatir.Add(1);

                //mevcut satır uçgene eklendi.
                ucgen.Add(mevcutSatir);
            }

            return ucgen;
        }
    }
}
