using LinkedListTwins;
using LinkedListTwins.Solutions;

// You can use this space to test your solution.
// Please clean up before you create a PR!

Node linkedList = LLGenerator.GenerateLinkedList();
Console.WriteLine(LLGenerator.Answer == Kenny.MaxTwinSum(linkedList));