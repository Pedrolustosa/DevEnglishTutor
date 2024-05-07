namespace DevEnglishTutor.Application.Interface
{
    /// <summary>
    /// The dev english tutor service interface.
    /// </summary>
    public interface IDevEnglishTutorService
    {
        Task<string> PromptResponse(string text);
    }
}
