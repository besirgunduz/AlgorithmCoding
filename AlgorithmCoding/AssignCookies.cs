using System;
using System.Drawing;
using System.Net;
using System.Numerics;

namespace AlgorithmCoding
{
    public class AssignCookies
    {
        //Assume you are an awesome parent and want to give your children some cookies. But, you should give each child at most one cookie.
        //Each child i has a greed factor g[i], which is the minimum size of a cookie that the child will be content with; and each cookie j has a size s[j].
        //If s[j] >= g[i], we can assign the cookie j to the child i, and the child i will be content.
        //Your goal is to maximize the number of your content children and output the maximum number.

        //Input: g = [1,2,3], s = [1,1]
        //Output: 1

        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            var childCount = 0;

            for (int i = 0; i < s.Length && childCount < g.Length; i++)
            {
                if (s[i] >= g[childCount])
                {
                    childCount++;
                }
            }

            return childCount;
        }
    }
}
