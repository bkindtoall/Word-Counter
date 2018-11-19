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
            Assert.AreEqual("3", WordCounterClass.CheckLetter("e"));
        }
        [TestMethod]
        public void IsUserInputStrings_ConfirmUserInputIsString_Bool()
        {
            string testWord = "bread";
            string testSentence = "the bread baked in the oven";
            Word myWord = new Word();
            
            Assert.AreEqual(true, myWord.IsUserInputStrings(testWord, testSentence));
        }        {
            Assert.AreEqual("0", WordCounterClass.CheckLetter("o"));
        }
        [TestMethod]
        public void CheckNumber_InputIsI_One()
        {
        string testSentence = "Snarfle Darfle";
        RepeatCounter newRepeatCounter = new RepeatCounter(testSentence);
        string result = newRepeatCounter.GetSentence();
        Assert.AreEqual(testSentence, result);        
        }
        // [TestMethod]
        // public void CheckNumber_InputIsT_Seven()
        // {
        //     Assert.AreEqual("7", WordCounterClass.CheckLetter("t"));
        // }
        // [TestMethod]
        // public void CheckNumber_InputIsS_Z()
        // {
        //     Assert.AreEqual("z", WordCounterClass.CheckLetter("s"));
        }
    }
}