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
        // [TestMethod]
        // public void CheckNumber_InputIsO_Zero()
        // {
        //     Assert.AreEqual("0", WordCounterClass.CheckLetter("o"));
        // }
        // [TestMethod]
        // public void CheckNumber_InputIsI_One()
        // {
        //     Assert.AreEqual("1", WordCounterClass.CheckLetter("I"));
        // }
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