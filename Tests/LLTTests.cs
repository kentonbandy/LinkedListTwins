using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTwins;
using LinkedListTwins.Solutions;

namespace Tests
{
    [TestClass]
    public class LLTTests
    {
        [TestInitialize]
        public void Setup()
        {
            LLGenerator.GenerateLinkedList();
        }

        [TestMethod]
        public void KennySpeedTest()
        {
            int actual = Kenny.MaxTwinSum1(LLGenerator.LinkedList);
            Assert.AreEqual(LLGenerator.Answer, actual);
        }

        [TestMethod]
        public void KennyCodeGolf()
        {
            int actual = Kenny.X(LLGenerator.LinkedList);
            Assert.AreEqual(LLGenerator.Answer, actual);
        }
    }
}