//backend
using System;

namespace Counter
{
    public class WordSentence
    {
        public int WordCounter(string word, string sentence)
        {
            string [] words = sentence.Split(" ");
            string lastWord = words[words.Length -1].TrimEnd('.');
            int wordCount = 0;
            for(int i=0; i < words.Length; i++)
            {
                if (words[i] == word || words[i] == lastWord) 
                {
                    wordCount +=1; 
                }
            }
            return wordCount;
        }
    }
}