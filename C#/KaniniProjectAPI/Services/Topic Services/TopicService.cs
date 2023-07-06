using KaniniProjectAPI.Data;
using KaniniProjectAPI.Models;
 using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaniniProjectAPI.Services.Topic_Services
{
    public class TopicService:ITopicService
    {
        private readonly KaniniDbContext _context;

        public TopicService(KaniniDbContext context)
        {
            _context = context;
        }

        public async Task<List<AvailableTopics>> AvailableTopics()
        {
            var AvailableTopic = (from topic in _context.Topics
                                  join question in _context.AddQuestions
                                  on topic.Id equals question.TopicId
                                  select new AvailableTopics()
                                  {
                                    TopicName = topic.TopicName,
                                    Question= question.Question.Count()
                                  }).ToListAsync();
                                  
            return await AvailableTopic;
        }
        public async Task<List<Topic>> GetTopics()
        {
            return await _context.Topics.ToListAsync();
        }
    }
}
