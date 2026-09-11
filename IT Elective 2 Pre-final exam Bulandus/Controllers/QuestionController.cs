namespace MyMVCApp.Models
{
    public class Question
    {
        public int Number { get; set; }

        public string Text { get; set; } = string.Empty;

        public List<string> Options { get; set; } = new List<string>();

        public string Answer { get; set; } = string.Empty;

        public string Explanation { get; set; } = string.Empty;
    }
}