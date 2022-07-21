namespace LinkedListTwins.Solutions
{
    internal static class Kenny
    {
        public static int MaxTwinSum(Node node)
        {
            if (node.Next != null) node = node.Next;
            return node.Val;
        }
    }
}
