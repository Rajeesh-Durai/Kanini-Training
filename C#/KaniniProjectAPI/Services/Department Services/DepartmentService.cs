using KaniniProjectAPI.Data;
using KaniniProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaniniProjectAPI.Services.Department_Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly KaniniDbContext _context;

        public DepartmentService(KaniniDbContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync(); 
        }
        public async Task<Department> AddDepartment(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return department;
        }
    }
}
