using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter;

namespace Counter.Test
{
    [TestClass]
    public class WordSentenceTests
    {

        WordSentence testWordSentence = new WordSentence();
        [TestMethod]
        public void WordCounter_NoWordInSentence_0()
        {
            Assert.AreEqual(0, testWordSentence.WordCounter("bananas", "I like apples."));
        }
        [TestMethod]
        public void WordCounter_NoSoloWordInSentence_0()
        {
            Assert.AreEqual(0, testWordSentence.WordCounter("crisp", "I love a good Honeycrisp apple."));
        }
        [TestMethod]
        public void WordCounter_OneWordInSentence_1()
        {
            Assert.AreEqual(1, testWordSentence.WordCounter("bananas", "I like bananas."));
        }
        [TestMethod]
        public void WordCounter_TwoWordsInSentence_2()
        {
            Assert.AreEqual(2, testWordSentence.WordCounter("shoes", "My shoes look just like your shoes."));
        }
    }
}