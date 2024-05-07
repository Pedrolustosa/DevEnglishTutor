namespace DevEnglishTutor.Application.Interface
{
    /// <summary>
    /// The dev english tutor service interface.
    /// </summary>
    public interface IDevEnglishTutorService
    {
        /// <summary>
        /// Prompts the response.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<string>]]></returns>
        Task<string> PromptResponse(string text);
    }
}
