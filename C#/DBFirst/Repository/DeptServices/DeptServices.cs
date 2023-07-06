using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecAPI.Models;

namespace SecAPI.Repository.DeptServices
{
    public class DeptServices : IDeptServices
    {
        public EmployeeContext _employeeContext;
        public DeptServices(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<IEnumerable<Dept>> GetDepts()
        {
            return await _employeeContext.Depts.ToListAsync();
        }
        public async Task<Dept>? GetDept(int id)
        {
            var dept = await _employeeContext.Depts.FindAsync(id);
            return dept;
        }
        public async Task<Dept> PutDept(int id, Dept dept)
        {
            var item = await _employeeContext.Depts.FindAsync(id);

            item.Deptno = dept.Deptno;
            item.Dname = dept.Dname;
            await _employeeContext.SaveChangesAsync();
            return dept;

        }
       public async Task<List<Dept>> PostDept(Dept dept)
        {
            await _employeeContext.Depts.AddAsync(dept);
            await _employeeContext.SaveChangesAsync();
            return await _employeeContext.Depts.ToListAsync();
        }
        public async Task<Dept>? DeleteDept(int id)
        {
         var dept = await _employeeContext.Depts.FindAsync(id);
          _employeeContext.Depts.Remove(dept);
         await _employeeContext.SaveChangesAsync();
            return dept;

        }
    }
}
