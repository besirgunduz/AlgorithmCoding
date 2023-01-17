using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class DefangingAnIPAddress
    {
        //Given a valid (IPv4) IP address, return a defanged version of that IP address.
        //A defanged IP address replaces every period "." with "[.]".

        //Input: address = "1.1.1.1"
        //Output: "1[.]1[.]1[.]1"

        public static string DefangingAnIPAddressResult(string adress)
        {
            return adress.Replace(".", "[.]");
        }

        //Result2
        public static string DefangingAnIPAddressResult2(string adress)
        {
            var sb = new StringBuilder();

            foreach (var c in adress)
            {
                if (c == '.')
                    sb.Append("[.]");
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
