using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterMain;

namespace WordCounterMain.Tests
{
    [TestClass]
    public class WordCounterClassTest
    {
        [TestMethod]
        public void CheckNumber_Input_One()
        {

        }
        [TestMethod]
        public void CheckWordToSentenceDups_Input_uno()
        {
            string testInputWord = "cat";
            string testInputSentence = "cat cats Cat ! category";
            string testResult = 
            
            Assert.AreEqual(testInputSentence, WordCounter.Counter(testInputWord));
        }        
        [TestMethod]
        public void CheckForEquality()
        {
            // var myClass = new WordCounter();
            // var result = myClass.SomeMethodINeedToCheck();
        
            // var expected = new MyClass(1, "some string1");
        
            // Assert.That.AreEqual(expected, result, new MyClassComparer());
        }
    }
}