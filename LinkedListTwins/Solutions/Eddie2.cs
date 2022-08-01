namespace LinkedListTwins.Solutions
{
    public static class Eddie2
    {
        public static int MaxTwinSum(Node node)
        {
            Node firstHalf = new Node(node.Val, null);
            Node secondHalf = node.Next;
            Node end = secondHalf;
            int max;

            while(end.Next != null)
            {
                end = end.Next.Next;
                firstHalf = new Node(secondHalf.Val, firstHalf);
                secondHalf = secondHalf.Next;
            }

            max = firstHalf.Val + secondHalf.Val;

            while(secondHalf.Next != null)
            {
                firstHalf = firstHalf.Next;
                secondHalf = secondHalf.Next;
                if(max < firstHalf.Val + secondHalf.Val)
                    max = firstHalf.Val + secondHalf.Val;
            }

            return max;
        }
    }
}
