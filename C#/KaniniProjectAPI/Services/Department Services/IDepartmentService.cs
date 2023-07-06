using KaniniProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KaniniProjectAPI.Services.Department_Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();
        Task<Department> AddDepartment(Department department);
        
    }
}
