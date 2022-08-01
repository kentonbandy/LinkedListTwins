using LinkedListTwins;
using LinkedListTwins.Solutions;
using BenchmarkDotNet.Attributes;

namespace Benchmarking
{
    [MemoryDiagnoser]
    [CsvExporter]
    public class LLTBenchmarks
    {
        public LLTBenchmarks()
        {
            // Build the linked list to be passed and set the answer prop.
            LLGenerator.GenerateLinkedList(
                $"../../../../{LLGenerator.IntsFile}",
                $"../../../../{LLGenerator.AnswerFile}"
                );
        }

        [Benchmark]
        public void BenchmarkEddie() => Verify(Eddie.MaxTwinSum);

        [Benchmark]
        public void BenchmarkEddie2() => Verify(Eddie2.MaxTwinSum);

        [Benchmark]
        public void BenchmarkEddie3() => Verify(Eddie3.MaxTwinSum);

        [Benchmark]
        public void BenchmarkKennyList() => Verify(Kenny.MaxTwinSumList);

        [Benchmark]
        public void BenchmarkKennyStack() => Verify(Kenny.MaxTwinSumStack);

        [Benchmark]
        public void BenchmarkKennyNode() => Verify(Kenny.MaxTwinSumNode);

        [Benchmark]
        public void BenchmarkKennyCodeGolf() => Verify(Kenny.X);

        [Benchmark]
        public void BenchmarkMike() => Verify(Mike.MaxTwinSum);

        // Ensure that the output of each run of the method is the correct answer or stop benchmarking by throwing an exception.
        private void Verify(Func<Node, int> method)
        {
            // Pass a new Node object built from the problem input in case the method is naughty and modifies it.
            Node input = new(LLGenerator.LinkedList.Val, LLGenerator.LinkedList.Next);
            bool isCorrect = method(input) == LLGenerator.Answer;
            if (!isCorrect) throw new Exception("Incorrect answer");
        }
    }
}
