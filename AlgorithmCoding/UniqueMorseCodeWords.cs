﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCoding
{
    public class UniqueMorseCodeWords
    {
        //International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:

        //'a' maps to ".-",
        //'b' maps to "-...",
        //'c' maps to "-.-.", and so on.
        //For convenience, the full table for the 26 letters of the English alphabet is given below:
        //[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        //Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
        //For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
        //Return the number of different transformations among all words we have.

        //Input: words = ["gin","zen","gig","msg"]
        //Output: 2

        public static int UniqueMorseRepresentations(string[] words)
        {

            var morse = new string[]
            {
                ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
            };
            var uniqueWords = new HashSet<string>();

            foreach (var word in words)
            {
                var sb = new StringBuilder();

                foreach (var c in word)
                {
                    sb.Append(morse[c - 'a']);
                }

                uniqueWords.Add(sb.ToString());
            }

            return uniqueWords.Count;
        }
    }
}
