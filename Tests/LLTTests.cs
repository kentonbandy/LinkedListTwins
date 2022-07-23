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
            int actual = Kenny.MaxTwinSumFast(LLGenerator.LinkedList);
            int answer = LLGenerator.Answer;
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void KennySpeedTest2()
        {
            int actual = Kenny.MaxTwinSumFast2(LLGenerator.LinkedList);
            int answer = LLGenerator.Answer;
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void KennyCodeGolfTest()
        {
            int actual = Kenny.X(LLGenerator.LinkedList);
            int answer = LLGenerator.Answer;
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }
    }
}