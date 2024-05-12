namespace DevEnglishTutor.Models
{
    public class Prompt
    {
        public Prompt()
        {
            Role = string.Empty;
            Content = string.Empty;
        }

        public Prompt(string role, string content)
        {
            Role = role;
            Content = content;
        }

        public string? Role { get; set; }
        public string? Content { get; set; }
    }
}
