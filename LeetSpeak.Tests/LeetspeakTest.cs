using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeakMain;

namespace LeetSpeakMain.Tests
{
    [TestClass]
    public class LeetSpeakClassTest
    {
        [TestMethod]
        public void CheckNumber_InputIsE_Three()
        {
            Assert.AreEqual("3", LeetSpeakClass.CheckLetter("e"));
        }
        [TestMethod]
        public void CheckNumber_InputIsO_Zero()
        {
            Assert.AreEqual("0", LeetSpeakClass.CheckLetter("o"));
        }
        [TestMethod]
        public void CheckNumber_InputIsI_One()
        {
            Assert.AreEqual("1", LeetSpeakClass.CheckLetter("I"));
        }
        [TestMethod]
        public void CheckNumber_InputIsT_Seven()
        {
            Assert.AreEqual("7", LeetSpeakClass.CheckLetter("t"));
        }
        [TestMethod]
        public void CheckNumber_InputIsS_Z()
        {
            Assert.AreEqual("z", LeetSpeakClass.CheckLetter("s"));
        }
    }
}