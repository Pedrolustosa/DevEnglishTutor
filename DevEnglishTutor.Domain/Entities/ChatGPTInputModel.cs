namespace DevEnglishTutor.Models
{
    /// <summary>
    /// The chat GPT input model.
    /// </summary>
    public class ChatGPTInputModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGPTInputModel"/> class.
        /// </summary>
        /// <param name="prompt">The prompt.</param>
        public ChatGPTInputModel(string prompt)
        {
            this.prompt = $"Correct this english phrase: {prompt}";
            temperature = 0.7m;
            max_tokens = 100;
            model = "gpt-3.5-turbo";
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        public string? model { get; set; }
        /// <summary>
        /// Gets or sets the prompt.
        /// </summary>
        public string? prompt { get; set; }
        /// <summary>
        /// Gets or sets the max tokens.
        /// </summary>
        public int max_tokens { get; set; }
        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public decimal temperature { get; set; }
    }

}
