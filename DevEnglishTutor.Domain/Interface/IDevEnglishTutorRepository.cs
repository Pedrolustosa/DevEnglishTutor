namespace DevEnglishTutor.Domain.Interface
{
    /// <summary>
    /// The dev english tutor repository interface.
    /// </summary>
    public interface IDevEnglishTutorRepository
    {
        /// <summary>
        /// Prompts the response.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<string>]]></returns>
        Task<string> PromptResponse(string text);
    }
}
