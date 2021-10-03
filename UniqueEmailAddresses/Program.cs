using System;
using System.Collections.Generic;

namespace UniqueEmailAddresses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Every valid email consists of a local name and a domain name, separated by the '@' sign. Besides lowercase letters, the email may contain one or more '.' or '+'.
            //For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.
            //For example, "m.y+name@email.com" will be forwarded to "my@email.com".

            //Input: emails = ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
            //Output: 2

            //Input: emails = ["a@leetcode.com","b@leetcode.com","c@leetcode.com"]
            //Output: 3

            var emails = new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };

            Console.WriteLine(NumUniqueEmails(emails));
        }

        public static int NumUniqueEmails(string[] emails)
        {
            var hashSet = new HashSet<string>(); //UniqueEmail

            foreach (var email in emails)
            {
                var index = email.IndexOf('@'); //15
                var local = email.Substring(0, index); //test.email+alex
                var domain = email.Substring(index); //@leetcode.com

                if (local.Contains('+'))
                {
                    local = local.Substring(0, local.IndexOf('+'));
                }

                local = local.Replace(".", "");

                hashSet.Add(local + domain);
            }

            return hashSet.Count;
        }
    }
}
