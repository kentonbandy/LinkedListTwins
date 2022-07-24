
# Linked List Twins

## Your task is to take a singly linked list of even length and return the largest sum of twin node values.

For this exercise, twin nodes are defined as those which are equidistant from the outer bounds of the linked list. The first and last nodes are twins, as are the two middle nodes. In a linked list of 10 nodes, the third and eighth nodes are twins.

The linked list you will be using comprises nodes of this class:

```csharp
internal class Node
{
    public int Val { get; set; }
    public Node? Next { get; set; }

    public Node(int val = 0, Node? next = null)
    {
        Val = val;
        Next = next;
    }
}
```

Node values range from 0 to 1,000,000. The linked list is of even length, and it's long enough that you don't want to try to do this problem by hand.

In order to build the linked list and pass it into your solution method, you need to use the static class LLGenerator. `LLGenerator.Generate()` will return a head Node (from the above class) that can be passed into your solution method.

Solutions will be benchmarked and compared, so try to come up with the best solution! What does the best mean? You can go for speed, low memory usage, shortest code, cleverest code, or most eloquent code. Or just try to have the most fun :)

You may have noticed that you have access to the answer. Don't get too comfortable; a new list and answer will be generated for the benchmarks! Your code must work.

If you have your code working and want more test cases, let me know.

## Simple Example

You can generate a simple input for debugging purposes. `LLGenerator.GenerateSimpleInput()` returns a head Node of a linked list that represents the following values: [3, 4, 6, 1, 7, 2]. For this simple example, your output should be 11, as the twins 4 and 7 have the greatest sum. You may also pass your own `int[]` into `LLGenerator.GenerateSimpleInput()` and it will generate a linked list with corresponding values so you can test some homemade cases.

## To Participate:

- Fork this repository.
- Create a public class with a unique name in the `Solutions` folder in this project and write a static method for your solution that takes a `Node` and returns an int.
- Create a pull request when you're done.
- On August 1st 2022 all valid PRs will be merged and everyone's solutions will be benchmarked.

## This problem

While this project setup is mine, I totally ripped this problem from leetcode. Find it here: [Leetcode - Maximum twin sum of a linked list](https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/)

Let me know what you like or don't like about this coding challenge format!
