namespace LinkedListTwins
{
    internal class IntListGenerator
    {
        public List<int> Ints { get; set; }
        private int Length { get; set; } = 1000;
        private int Min { get; set; } = 0;
        private int Max { get; set; } = 1000000;
        public int Answer { get; set; }
        private readonly string FilePath = LLGenerator.IntsFile;
        private readonly string AnswerPath = LLGenerator.AnswerFile;

        public IntListGenerator()
        {
            Ints = new List<int>();
            Random r = new();
            for (int i = 0; i < Length; i++) Ints.Add(r.Next(Min, Max));
            for (int i = 0, j = Length - 1; i < Length / 2; i++, j--)
            {
                Answer = Math.Max(Answer, Ints[i] + Ints[j]);
            }
        }

        public async Task GenerateTextFiles()
        {
            await File.WriteAllLinesAsync(FilePath, Ints.Select(i => i.ToString()));
            await File.WriteAllTextAsync(AnswerPath, Answer.ToString());
        }
    }
}
