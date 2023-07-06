using Microsoft.AspNetCore.Mvc;
using ThirdAPI.Models;

namespace ThirdAPI.Repository.Services.EmpServices
{
    public interface IEmpServices
    {
        Task<IEnumerable<Emp>> GetEmps();
        Task<Emp?> GetEmp(int id);
        Task<Emp> PutEmp(int id, Emp emp);
        Task<List<Emp>> PostEmp(Emp emp);
        Task<Emp> DeleteEmp(int id);
    }
}
