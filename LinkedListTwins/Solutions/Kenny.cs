namespace LinkedListTwins.Solutions
{
    internal static class Kenny
    {
        // fast
        public static int MaxTwinSum1(Node node)
        {
            List<int> lst = new();
            for (; node != null; node = node.Next) lst.Add(node.Val);
            int len = lst.Count;
            for (int i = 0, j = len - 1; i < len / 2; i++, j--) lst[i] += lst[j];
            return lst.GetRange(0, len / 2).Max();
        }

        // code golf
        public static int X(Node n){for(Node f=n,s=n,r=new(n.Next.Val,new(n.Val));s!=null;n.Val=f==null?Math.Max(n.Val,r.Val+s.Val):n.Val,s=s.Next,f=f?.Next?.Next,r=f!=null?new(s.Next.Val,r):r.Next);return n.Val;}

        // code golf solution, written out
        public static int MaxTwinSumX(Node node)
        {
            for (
                Node fast = node,
                slow = node,
                reverse = new(node.Next.Val, new(node.Val));

                slow != null;

                node.Val = fast == null ? Math.Max(node.Val, reverse.Val + slow.Val) : node.Val,
                slow = slow.Next,
                fast = fast?.Next?.Next,
                reverse = fast != null ? new(slow.Next.Val, reverse) : reverse.Next
                )
            { }
            return node.Val;
        }
    }
}
