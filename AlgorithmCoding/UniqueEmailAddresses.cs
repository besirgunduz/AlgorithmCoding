using System.Collections.Generic;

namespace AlgorithmCoding
{
    public class UniqueEmailAddresses
    {
        //Every valid email consists of a local name and a domain name, separated by the '@' sign. Besides lowercase letters, the email may contain one or more '.' or '+'.
        //For example, in "alice@leetcode.com", "alice" is the local name, and "leetcode.com" is the domain name.
        //For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.
        //For example, "m.y+name@email.com" will be forwarded to "my@email.com".

        //Input: emails = ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
        //Output: 2

        public static int NumUniqueEmails(string[] emails)
        {
            var emailSet = new HashSet<string>();

            for (int i = 0; i < emails.Length; i++)
            {
                var index = emails[i].IndexOf('@');
                var local = emails[i].Substring(0, index);
                var domain = emails[i].Substring(index);

                if (local.Contains('+'))
                    local = local.Substring(0, local.IndexOf('+'));

                local = local.Replace(".", "");

                emailSet.Add(local + domain);
            }

            return emailSet.Count;
        }
    }
}
