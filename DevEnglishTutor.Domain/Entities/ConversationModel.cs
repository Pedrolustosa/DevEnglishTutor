using System.Reflection;

namespace DevEnglishTutor.Models
{
    public class ConversationModel
    {
        public ConversationModel()
        {
            Model = string.Empty;
            Prompt = Array.Empty<Prompt>();
        }

        public ConversationModel(string model, Prompt[] prompt)
        {
            Model = model;
            Prompt = prompt;
        }

        public required string Model { get; set; }
        public required Prompt[] Prompt { get; set; }    
    }   
}
