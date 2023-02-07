using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AlgorithmCoding
{
    public class RemoveAllDuplicates
    {
        //You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.
        //We repeatedly make duplicate removals on s until we no longer can.
        //Return the final string after all such duplicate removals have been made.It can be proven that the answer is unique.

        //Input: s = "abbaca"
        //Output: "ca"

        //Input: s = "azxxzy"
        //Output: "ay"

        public static string RemoveAllDuplicatesResult(string s)
        {
            var chars=new char[s.Length];
            var position = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (position > 0 && chars[position - 1] == s[i])
                    position--;
                else
                {
                    chars[position] = s[i];
                    position++;
                }
            }

            return new string(chars,0,position);
        }
    }
}
