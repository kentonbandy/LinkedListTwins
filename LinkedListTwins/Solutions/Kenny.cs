namespace LinkedListTwins.Solutions
{
    public static class Kenny
    {
        // fast
        public static int MaxTwinSumFast2(Node node)
        {
            List<int> lst = new();
            for (; node != null; node = node.Next) lst.Add(node.Val);
            int len = lst.Count;
            int maxSum = lst[0];
            for (int i = 0, j = len - 1; i < len / 2; i++, j--) maxSum = Math.Max(maxSum, lst[i] + lst[j]);
            return maxSum;
        }

        // code golf
        public static int X(Node n){for(Node f=n,s=n,r=new(n.Next.Val,new(n.Val));s!=null;n.Val=f==null?Math.Max(n.Val,r.Val+s.Val):n.Val,s=s.Next,f=f?.Next?.Next,r=f!=null?new(s.Next.Val,r):r.Next);return n.Val;}

        // code golf solution, written out
        public static int MaxTwinSumX(Node node)
        {
            for (
                // Initialize fast and slow pointers and a reverse node that will be built as we traverse. The passed node will be used to set these values, then to store the maxSum value so that we can return it outside the scope of the for loop.
                Node fast = node,
                slow = node,
                reverse = new(node.Next.Val, new(node.Val));

                // When the slow pointer is null, we have traversed the linked list.
                slow != null;

                // When we've reached the middle of the linked list (fast == null), compare the val of the slow and reverse nodes.
                node.Val = fast == null ? Math.Max(node.Val, reverse.Val + slow.Val) : node.Val,
                // The slow pointer always moves one node forward.
                slow = slow.Next,
                // The fast node moves two nodes forward until it becomes null, then it stays null. Its nullness will be used to determine if the slow node is halfway through the linked list.
                fast = fast?.Next?.Next,
                // The reverse linked list is built until we've reached the middle (fast == null), then it simply traverses in the opposite direction as our slow pointer. The fast and slow pointers will be on twins after we reach the middle.
                reverse = fast != null ? new(slow.Next.Val, reverse) : reverse.Next
                )
            { } // No for loop block code is necessary; all the work is being done in the initializer's third statement.
            // Now we simply return the param variable's val which was used to store the maxSum.
            return node.Val;
        }
    }
}
