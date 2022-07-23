using LinkedListTwins;
using LinkedListTwins.Solutions;
using BenchmarkDotNet.Attributes;

namespace Benchmarking
{
    public class LLTBenchmarks
    {
        public LLTBenchmarks()
        {
            // Build the linked list to be passed and set the answer prop.
            LLGenerator.GenerateLinkedList();
        }

        [Benchmark]
        public void BenchmarkKenny2() => Verify(Kenny.MaxTwinSumFast2);

        [Benchmark]
        public void BenchmarkKenny3() => Verify(Kenny.X);

        // Ensure that the output of the method is the correct answer or stop benchmarking by throwing an exception.
        private void Verify(Func<Node, int> method)
        {
            // Pass a new Node object built from the problem input in case the method is naughty and modifies it.
            bool isCorrect = method(new Node(LLGenerator.LinkedList)) == LLGenerator.Answer;
            if (!isCorrect) throw new Exception("Incorrect answer");
        }
    }
}
