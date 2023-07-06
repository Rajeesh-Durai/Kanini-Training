using KaniniProjectAPI.Data;
using KaniniProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaniniProjectAPI.Services.AddQuestionServices
{
    public class AddQuestionService:IAddQuestionService
    {
        private readonly KaniniDbContext _context;

        public AddQuestionService(KaniniDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<AddQuestion>> GetQuestions()
        {
            return await _context.AddQuestions.ToListAsync();
        }
    }
}
