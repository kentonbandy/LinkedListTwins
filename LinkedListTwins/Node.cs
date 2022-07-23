namespace LinkedListTwins
{
    public class Node
    {
        public int Val { get; set; }
        public Node? Next { get; set; }

        public Node(int val = 0, Node? next = null)
        {
            Val = val;
            Next = next;
        }

        public Node(Node node)
        {
            this.Val = node.Val;
            this.Next = node.Next;
        }
    }
}
