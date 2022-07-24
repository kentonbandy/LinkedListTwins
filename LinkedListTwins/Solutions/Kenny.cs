namespace LinkedListTwins.Solutions
{
    public static class Kenny
    {
        // fast
        public static int MaxTwinSumList(Node node)
        {
            List<int> lst = new();
            for (; node != null; node = node.Next) lst.Add(node.Val);
            int len = lst.Count;
            int maxSum = lst[0];
            for (int i = 0, j = len - 1; i < len / 2; i++, j--) maxSum = Math.Max(maxSum, lst[i] + lst[j]);
            return maxSum;
        }

        // low memory use
        public static int MaxTwinSumStack(Node node)
        {
            Stack<int> s = new();
            int maxSum = node.Val;
            // fill the stack while traversing first half, then get maxSum
            for (Node fast = node; node != null; node = node.Next, fast = fast?.Next?.Next)
            {
                if (fast == null) maxSum = Math.Max(maxSum, node.Val + s.Pop());
                else s.Push(node.Val);
            }
            return maxSum;
        }

        // only linked lists
        public static int MaxTwinSumNode(Node node)
        {
            int maxSum = node.Val;
            // slow/fast pointers and reverse list to middle, then take max sum of slow and reverse values as they traverse outward
            for (Node fast = node, rev = null; node != null; node = node.Next, fast = fast?.Next?.Next)
            {
                if (fast == null)
                {
                    maxSum = Math.Max(maxSum, node.Val + rev.Val);
                    rev = rev.Next;
                }
                else rev = new(node.Val, rev);
            }
            return maxSum;
        }

        // code golf - essentially the same as node solution, but all variables declared in the for loop and the passed node is used to store maxSum for one-lineyness
        // n = node(used to store maxSum after other node types are set), f = fast, s = slow, r = reverse
        public static int X(Node n){for(Node f=n,s=n,r=new(n.Next.Val,new(n.Val));s!=null;n.Val=f==null?Math.Max(n.Val,r.Val+s.Val):n.Val,s=s.Next,f=f?.Next?.Next,r=f!=null?new(s.Next.Val,r):r.Next);return n.Val;}
    }
}
