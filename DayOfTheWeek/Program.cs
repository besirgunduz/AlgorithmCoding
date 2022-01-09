using System;

namespace DayOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given a date, return the corresponding day of the week for that date.
            //The input is given as three integers representing the day, month and year respectively.
            //Return the answer as one of the following values
            //{ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}.

            //Input: day = 31, month = 8, year = 2019
            //Output: "Saturday"

            //Input: day = 18, month = 7, year = 1999
            //Output: "Sunday"

            int day = 10; int month = 10; int year = 1993;
            Console.WriteLine(DayOfTheWeek(day, month, year));
        }

        private static string DayOfTheWeek(int day, int month, int year)
        {
            var dt=new DateTime(year,month,day);
            return dt.DayOfWeek.ToString();
        }
    }
}
