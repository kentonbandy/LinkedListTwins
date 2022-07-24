namespace LinkedListTwins
{
    public static class LLGenerator
    {
        public static Node LinkedList { get; private set; }
        public static int Answer { get; set; }
        public static readonly string IntsFile = "../../../../LinkedListTwins/Files/Ints.txt";
        public static readonly string AnswerFile = "../../../../LinkedListTwins/Files/Answer.txt";

        public static Node GenerateLinkedList(string intsFile = null, string answerFile = null)
        {
            if (intsFile == null) intsFile = IntsFile;
            if (answerFile == null) answerFile = AnswerFile;
            int[] ints = File.ReadAllLines(intsFile).Select(s => int.Parse(s)).ToArray();
            LinkedList = BuildLinkedList(ints);
            Answer = int.Parse(File.ReadAllText(answerFile));
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
