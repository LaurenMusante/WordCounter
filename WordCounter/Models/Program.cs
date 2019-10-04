//frontend
using System;
using Counter;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Please enter a word: ");
        string word = Console.ReadLine();
        Console.WriteLine("Please enter a sentence using the word you selected (or not!): ");
        string sentence = Console.ReadLine();
        WordSentence myWordSentence = new WordSentence();
        int wordCount = myWordSentence.WordCounter(word, sentence);
        
        if (myWordSentence.WordCounter(word, sentence) == 0)
            {
                Console.WriteLine("Your sentence does not contain your word ☹️");
            }
        else if (myWordSentence.WordCounter(word, sentence) == wordCount)
            {
                Console.WriteLine("Your sentence contains your word " + wordCount + " times!");
            }
    }
}