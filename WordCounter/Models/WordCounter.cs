//backend
using System;

namespace Counter
{
    public class WordSentence
    {
        public string Word { get; set; }
        public string Sentence { get; set; }

        public void WordCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }
    }
}