namespace LinkedListTwins
{
    internal static class LLGenerator
    {
        public static int Answer { get; set; }
        private static readonly string IntsFile = "../../../Files/Ints.txt";
        private static readonly string AnswerFile = "../../../Files/Answer.txt";

        public static Node GenerateLinkedList()
        {
            int[] ints = File.ReadAllLines(IntsFile).Select(s => int.Parse(s)).ToArray();
            Answer = int.Parse(File.ReadAllText(AnswerFile));
            return BuildLinkedList(ints);
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
