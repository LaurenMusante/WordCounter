//backend
using System;

namespace Counter
{
    public class WordSentence
    {
        public int WordCounter(string word, string sentence)
        {
            //string NewString = MyString.TrimEnd(MyChar);
            string [] words = sentence.Split(" ");
            string noPeriods = words[words.Length + 1].TrimEnd(string .);
            int wordCount = 0;
            for(int i=0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    wordCount +=1; 
                }
            }
            return wordCount;
        }
    }
}