using System;
using System.Globalization;

namespace DayOfYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given a string date representing a Gregorian calendar date formatted as YYYY - MM - DD, return the day number of the year.

            //Input: date = "2019-01-09"
            //Output: 9

            //Input: date = "2019-02-10"
            //Output: 41

            var date = "2019-02-10";
            Console.WriteLine(DayOfYear(date));
        }

        private static int DayOfYear(string date)
        {
            var dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return dt.DayOfYear;
        }
    }
}
