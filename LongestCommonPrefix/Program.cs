using System;
using System.Text;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "flower", "flow", "flight","flc","fmm" }; //f

            LongestCommonPrefix(str);

            string LongestCommonPrefix(string[] strs)
            {
                StringBuilder sb = new StringBuilder();

                int enKucuk = int.MaxValue; //3

                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i].Length<enKucuk)
                    {
                        enKucuk = strs[i].Length;
                    }
                }

                for (int i = 0; i < enKucuk; i++)
                {
                    for (int j = 0; j < strs.Length; j++)
                    {
                        if (strs[j][i] == strs[1][i])
                        {

                        }
                    }
                }

                string sonuc = sb.ToString();

                return sonuc;
            }
        }
    }
}
