namespace DevEnglishTutor.Models
{
    /// <summary>
    /// The chat GPT view model.
    /// </summary>
    public class ChatGPTViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string? id { get; set; }
        /// <summary>
        /// Gets or sets the object.
        /// </summary>
        public string? @object { get; set; }
        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        public int created { get; set; }
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        public string? model { get; set; }
        /// <summary>
        /// Gets or sets the choices.
        /// </summary>
        public List<Choice>? choices { get; set; }
        /// <summary>
        /// Gets or sets the usage.
        /// </summary>
        public Usage? usage { get; set; }
    }

    /// <summary>
    /// The choice.
    /// </summary>
    public class Choice
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string? text { get; set; }
        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// Gets or sets the logprobs.
        /// </summary>
        public object? logprobs { get; set; }
        /// <summary>
        /// Gets or sets the finish reason.
        /// </summary>
        public string? finish_reason { get; set; }
    }

    /// <summary>
    /// The usage.
    /// </summary>
    public class Usage
    {
        /// <summary>
        /// Gets or sets the prompt tokens.
        /// </summary>
        public int prompt_tokens { get; set; }
        /// <summary>
        /// Gets or sets the completion tokens.
        /// </summary>
        public int completion_tokens { get; set; }
        /// <summary>
        /// Gets or sets the total tokens.
        /// </summary>
        public int total_tokens { get; set; }
    }
}
