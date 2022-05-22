using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class DayOfYear
    {
        //Given a string date representing a Gregorian calendar date formatted as YYYY - MM - DD, return the day number of the year.

        //Input: date = "2019-01-09"
        //Output: 9

        //Input: date = "2019-02-10"
        //Output: 41

        public static int DayOfYearResult(string date)
        {
            var dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return dt.DayOfYear;
        }
    }
}
