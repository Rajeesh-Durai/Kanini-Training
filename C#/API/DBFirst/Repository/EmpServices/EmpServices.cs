using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecAPI.Models;

namespace SecAPI.Repository.EmpServices
{
    public class EmpServices: IEmpServices
    {
        public EmployeeContext _employeecontext;
        public EmpServices(EmployeeContext employeecontext)
        {
            _employeecontext = employeecontext;
        }
        public async Task<IEnumerable<Emp>> GetEmps()
        {
            return await _employeecontext.Emps.ToListAsync();
        }
        public async Task<Emp?> GetEmp(int id)
        {
            var emp=await _employeecontext.Emps.FindAsync(id);
            return emp;
        }
        public async Task<Emp> PutEmp(int id, Emp emp)
        {
           var item= await _employeecontext.Emps.FindAsync(id);
           item.Eno=emp.Eno;
            item.Ename=emp.Ename;
           await _employeecontext.SaveChangesAsync();
            return emp;
        }
        public async Task<List<Emp>> PostEmp(Emp emp)
        {
            var item=_employeecontext.Emps.AddAsync(emp);
            await _employeecontext.SaveChangesAsync();
            return await _employeecontext.Emps.ToListAsync();
        }
        public async Task<Emp> DeleteEmp(int id)
        {
            var emp = await _employeecontext.Emps.FindAsync(id);
            _employeecontext.Emps.Remove(emp);
            await _employeecontext.SaveChangesAsync();
            return emp;
        }
    }
}
