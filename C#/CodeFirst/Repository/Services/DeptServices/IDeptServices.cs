using ThirdAPI.Models;

namespace ThirdAPI.Repository.Services.DeptServices
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
