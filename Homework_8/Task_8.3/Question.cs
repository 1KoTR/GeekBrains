namespace Task_8._3
{
    public class Question
    {
        public string Text { get; set; }
        public bool Answer { get; set; }

        public Question(string text, bool isTrue)
        {
            Text = text;
            Answer = isTrue;
        }
    }
}
