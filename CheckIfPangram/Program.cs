using System;

namespace CheckIfPangram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //A pangram is a sentence where every letter of the English alphabet appears at least once.
            //Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.

            //Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
            //Output: true
            //Explanation: sentence contains at least one of every letter of the English alphabet.

            string sentence = "thequickbrownfoxjumpsoverthelazydog";
            Console.WriteLine(CheckIfPangram(sentence));
            Console.ReadKey();
        }

        private static bool CheckIfPangram(string sentence)
        {
            var arr = new int[26];

            for (int i = 0; i < sentence.Length; i++)
            {
                arr[sentence[i] - 'a']++;
            }

            foreach (var item in arr)
            {
                if (item == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
