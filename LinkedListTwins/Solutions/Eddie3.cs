namespace LinkedListTwins.Solutions
{
    public static class Eddie3
    {
        public static int MaxTwinSum(Node node)
        {
            Node firstHalf = new Node(node.Val, null);
            Node firstHalfMax;
            Node secondHalf = node.Next;
            Node secondHalfMaxAndEnd = secondHalf;

            while (secondHalfMaxAndEnd.Next != null)
            {
                secondHalfMaxAndEnd = secondHalfMaxAndEnd.Next.Next;
                firstHalf = new Node(secondHalf.Val, firstHalf);
                secondHalf = secondHalf.Next;
            }

            firstHalfMax = firstHalf;
            secondHalfMaxAndEnd = secondHalf;

            while (secondHalf.Next != null)
            {
                firstHalf = firstHalf.Next;
                secondHalf = secondHalf.Next;
                if (firstHalfMax.Val + secondHalfMaxAndEnd.Val < firstHalf.Val + secondHalf.Val)
                {
                    firstHalfMax = firstHalf;
                    secondHalfMaxAndEnd = secondHalf;
                }
            }

            return firstHalfMax.Val + secondHalfMaxAndEnd.Val;
        }
    }
}
