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
        public void WordCounter_WordIsSentence_1()
        {
            Assert.AreEqual(1, testWordSentence.WordCounter("pizza", "pizza"));
        }

        [TestMethod]
        public void WordCounter_OneWordInSentence_1()
        {
            Assert.AreEqual(1, testWordSentence.WordCounter("bananas", "My favorite thing to eat is bananas with peanut butter."));
        }

        [TestMethod]
        public void WordCounter_TwoWordsInSentence_2()
        {
            Assert.AreEqual(2, testWordSentence.WordCounter("shoes", "I have shoes that belong to be and shoes that belong to my brother."));
        }

        [TestMethod]
        public void WordCounter_ThreeWordInSentence_3()
        {
            Assert.AreEqual(3, testWordSentence.WordCounter("nachos", "If you like nachos you are going to love my nachos flavored nachos with guacamole."));
        }

        [TestMethod]
        public void WordCounter_FiveWordsInSentence_5()
        {
            Assert.AreEqual(5, testWordSentence.WordCounter("code", "I heard you like coding so I wrote code that can code while you code code that can code"));
        }
    }
}