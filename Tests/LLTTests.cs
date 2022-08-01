using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTwins;
using LinkedListTwins.Solutions;

namespace Tests
{
    /// <summary>
    /// These tests ensure that 1. The methods output the correct answer and 2. The methods don't modify the LLGenerator.Answer property
    /// </summary>
    [TestClass]
    public class LLTTests
    {
        // Runs before every test
        [TestInitialize]
        public void Setup()
        {
            LLGenerator.GenerateLinkedList();
        }

        [TestMethod]
        public void EddieSimpleSolution()
        {
            int answer = LLGenerator.Answer;
            int actual = Eddie.MaxTwinSum(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void Eddie2Solution()
        {
            int answer = LLGenerator.Answer;
            int actual = Eddie2.MaxTwinSum(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void Eddie3Solution()
        {
            int answer = LLGenerator.Answer;
            int actual = Eddie3.MaxTwinSum(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void KennyList()
        {
            int answer = LLGenerator.Answer;
            int actual = Kenny.MaxTwinSumList(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void KennyStack()
        {
            int answer = LLGenerator.Answer;
            int actual = Kenny.MaxTwinSumStack(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void KennyNode()
        {
            int answer = LLGenerator.Answer;
            int actual = Kenny.MaxTwinSumNode(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void KennyCodeGolfTest()
        {
            int answer = LLGenerator.Answer;
            int actual = Kenny.X(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }

        [TestMethod]
        public void MikeFirstSolution()
        {
            int answer = LLGenerator.Answer;
            int actual = Mike.MaxTwinSum(LLGenerator.LinkedList);
            Assert.AreEqual(answer, actual);
            Assert.AreEqual(answer, LLGenerator.Answer);
        }
    }
}