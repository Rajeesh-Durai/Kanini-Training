using Microsoft.AspNetCore.Mvc;
using SecAPI.Models;
namespace SecAPI.Repository.DeptServices
{
    public interface IDeptServices
    {
        Task<IEnumerable<Dept>> GetDepts();
        Task<Dept>? GetDept(int id);
        Task<Dept> PutDept(int id, Dept dept);
        Task<List<Dept>> PostDept(Dept dept);
        Task<Dept>? DeleteDept(int id);
    }
}
