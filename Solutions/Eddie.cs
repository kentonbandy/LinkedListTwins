using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTwins.Solutions
{
    internal static class Eddie
    {
        public static int MaxTwinSum(Node node)
        {
            List<int> numbers = BuildList(node);
            List<int> firstHalf = numbers.GetRange(0, numbers.Count/2);
            List<int> secondHalf = numbers.GetRange(numbers.Count / 2, numbers.Count / 2);
            IEnumerable<int> totals = firstHalf.Select((x, i) => x + secondHalf[secondHalf.Count - i -1]);
            return totals.Max();
        }

        private static List<int> BuildList(Node node)
        {
            List<int> list = new();
            while(node.Next != null)
            {
                list.Add(node.Val);
                node = node.Next;
            }
            list.Add(node.Val);
            return list;
        }
    }
}
