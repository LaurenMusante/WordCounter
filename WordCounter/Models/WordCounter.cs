//backend
using System;

namespace Counter
{
    public class WordSentence
    {
        public int WordCounter(string word, string sentence)
        {
            string [] words = sentence.Split(" ");
            int wordCount = 0;
            for(int i=0; i < words.Length; i++)
            {
                if (words[i] != word)
                {
                    Console.WriteLine("Your word is not contained in your sentence.");
                }
                else if (words[i] == word)
                {
                    wordCount +=1; 
                }
            }
            return wordCount;
        }
    }
}