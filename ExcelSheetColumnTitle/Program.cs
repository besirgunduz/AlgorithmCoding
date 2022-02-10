using System;
using System.Text;

namespace ExcelSheetColumnTitle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

            //Input: columnNumber = 28
            //Output: "AB"

            //Input: columnNumber = 701
            //Output: "ZY"

            Console.WriteLine(ConvertToTitle(701));
        }

        private static string ConvertToTitle(int columnNumber)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sb = new StringBuilder();

            while (columnNumber > 0)
            {
                columnNumber--;
                var addedChar = columnNumber % 26;
                sb.Insert(0, chars[addedChar]);
                columnNumber /= 26;
            }

            return sb.ToString();
        }
    }
}
