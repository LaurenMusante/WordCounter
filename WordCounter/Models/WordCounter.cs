//backend
using System;

namespace Counter
{
    public class WordSentence
    {
        public int WordCounter(string word, string sentence)
        {
            string [] words = sentence.Split(" ");
            // string lastWord = words[words.Length -1].TrimEnd('.');
            int wordCount = 0;
            for(int i=0; i < words.Length; i++)
            {
                char [] charsToGetRidOf = { '.', ',', '?', '!', ';'};
                string trimmedWord = words[i].TrimEnd(charsToGetRidOf);
                if (trimmedWord == word) 
                {
                    wordCount +=1; 
                }
            }
            return wordCount;
        }
    }
}
