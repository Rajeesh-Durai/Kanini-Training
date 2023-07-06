using KaniniProjectAPI.Models;

namespace KaniniProjectAPI.Services.AddQuestionServices
{
    public interface IAddQuestionService
    {
        Task<IEnumerable<AddQuestion>> GetQuestions();
    }
}
