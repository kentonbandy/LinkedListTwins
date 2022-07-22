using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTwins.Solutions
{
    internal static class Mike
    {
        // my very quickly done first pass at this just to get something working

        public static int MaxTwinSum(Node node)
        {
            int totalNodes = 0;
            Dictionary<int, int> hash = new Dictionary<int, int>();
            bool endList = false;

           while (!endList)
            {
                hash[totalNodes] = node.Val;
                if(node.Next != null)
                {
                    node = node.Next;
                    totalNodes++;
                } else
                {
                    endList = true;
                }
            }

            int maxSum = int.MinValue;

            for (int i = 0; i < totalNodes / 2; i++)
            {
                if((hash[i] + hash[totalNodes-i]) > maxSum)
                {
                    maxSum = hash[i] + hash[totalNodes-i];
                }
            }

            return maxSum;
        }
    }
}
