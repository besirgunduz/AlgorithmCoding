using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public static class SingleElement
    {
        //You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once.
        //Return the single element that appears only once.

        //Input: nums = [1,1,2,3,3,4,4,8,8]
        //Output: 2

        public static int SingleNonDublicate(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);
            }

            foreach (var num in nums)
            {
                if (dic[num] == 1)
                    return num;
            }

            return -1;
        }
    }
}
