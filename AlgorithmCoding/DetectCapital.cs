namespace AlgorithmCoding
{
    public class DetectCapital
    {
        //We define the usage of capitals in a word to be right when one of the following cases holds:
        //All letters in this word are capitals, like "USA".
        //All letters in this word are not capitals, like "leetcode".
        //Only the first letter in this word is capital, like "Google".
        //Given a string word, return true if the usage of capitals in it is right.

        //Input: word = "FlaG"
        //Output: false

        public static bool DetectCapitalResult(string word)
        {
            var count = 0;

            foreach (var item in word)
            {
                if (char.IsUpper(item))
                    count++;
            }

            return count == word.Length || count == 0 || (count == 1 && char.IsUpper(word[0]));
        }
    }
}