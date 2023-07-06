using KaniniProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KaniniProjectAPI.Services.Topic_Services
{
    public interface ITopicService
    {
        Task<List<AvailableTopics>> AvailableTopics();
        Task<List<Topic>> GetTopics();
    }
}
