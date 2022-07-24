using LinkedListTwins;
using LinkedListTwins.Solutions;

// You can use this space to test your solution.
// Please clean up before you create a PR!


Node linkedListHead = LLGenerator.GenerateLinkedList();
Node simpleExample = LLGenerator.GenerateSimpleInput();
Console.WriteLine(Kenny.MaxTwinSumList(simpleExample) == 11);
Console.WriteLine(Kenny.MaxTwinSumList(linkedListHead) == LLGenerator.Answer);
