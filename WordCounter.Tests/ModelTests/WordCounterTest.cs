using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter;

namespace Counter.Test
{
    [TestClass]
    public class WordSentenceTests
    {

        WordSentence testWordSentence = new WordSentence();
        [TestMethod]
        public int WordCounter_NoWordInSentence_0()
        {
            Assert.AreEqual(0, testWordSentence.WordCounter("bananas", "I like apples."))
        }
        [TestMethod]
        public int WordCounter_NoSoloWordInSentence_0()
        {
            Assert.AreEqual(0, testWordSentence.WordCounter("crisp", "I love a good Honeycrisp apple."))
        }
        [TestMethod]
        public int WordCounter_OneWordInSentence_1()
        {
            Assert.AreEqual(1, testWordSentence.WordCounter("bananas", "I like bananas."))
        }
        [TestMethod]
        public int WordCounter_TwoWordsInSentence_2()
        {
            Assert.AreEqual(2, testWordSentence.WordCounter("shows", "My shoes look just like your shoes."))
        }
    }
}