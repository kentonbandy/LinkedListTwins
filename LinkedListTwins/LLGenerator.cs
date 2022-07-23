namespace LinkedListTwins
{
    public static class LLGenerator
    {
        public static Node LinkedList { get; private set; }
        public static int Answer { get; set; }
        private static readonly string IntsFile = "../../../../LinkedListTwins/Files/Ints.txt";
        private static readonly string AnswerFile = "../../../../LinkedListTwins/Files/Answer.txt";

        public static Node GenerateLinkedList()
        {
            int[] ints = File.ReadAllLines(IntsFile).Select(s => int.Parse(s)).ToArray();
            LinkedList = BuildLinkedList(ints);
            Answer = int.Parse(File.ReadAllText(AnswerFile));
            return LinkedList;
        }

        public static Node GenerateSimpleInput(int[]? ints = null)
        {
            if (ints == null) ints = new int[] { 3, 4, 6, 1, 7, 2 };
            return BuildLinkedList(ints);
        }

        private static Node BuildLinkedList(int[] ints)
        {
            return BuildLinkedList(ints, 0) ?? new();
        }

        private static Node? BuildLinkedList(int[] ints, int index)
        {
            if (index >= ints.Length) return null;
            return new(ints[index], BuildLinkedList(ints, index + 1));
        }
    }
}
