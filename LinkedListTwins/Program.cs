using LinkedListTwins;
using LinkedListTwins.Solutions;

// You can use this space to test your solution.
// Please clean up before you create a PR!

Node linkedList = LLGenerator.GenerateLinkedList();
Node smallList = LLGenerator.GenerateSimpleInput(new int[] {4,2,2,3});
Console.WriteLine(LLGenerator.Answer == Kenny.MaxTwinSum1(linkedList));
linkedList = LLGenerator.GenerateLinkedList();
Console.WriteLine(LLGenerator.Answer == Kenny.X(linkedList));
linkedList = LLGenerator.GenerateLinkedList();
Console.WriteLine(LLGenerator.Answer == Kenny.MaxTwinSumX(linkedList));
Console.WriteLine(Kenny.X(smallList));
