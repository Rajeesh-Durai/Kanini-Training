using Microsoft.EntityFrameworkCore;
using ThirdAPI.Models;

namespace ThirdAPI.Repository.Services.EmpServices
{
    public class EmpServices:IEmpServices
    {
        public CompanyContext _companyContext;
        public EmpServices(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }
        public async Task<IEnumerable<Emp>> GetEmps()
        {
            return await _companyContext.Emps.ToListAsync();
        }
        public async Task<Emp?> GetEmp(int id)
        {
            var emp = await _companyContext.Emps.FindAsync(id);
            return emp;
        }
        public async Task<Emp> PutEmp(int id, Emp emp)
        {
            var item = await _companyContext.Emps.FindAsync(id);
            item.Eno = emp.Eno;
            item.Ename = emp.Ename;
            await _companyContext.SaveChangesAsync();
            return emp;
        }
        public async Task<List<Emp>> PostEmp(Emp emp)
        {
            var item = _companyContext.Emps.AddAsync(emp);
            await _companyContext.SaveChangesAsync();
            return await _companyContext.Emps.ToListAsync();
        }
        public async Task<Emp> DeleteEmp(int id)
        {
            var emp = await _companyContext.Emps.FindAsync(id);
            _companyContext.Emps.Remove(emp);
            await _companyContext.SaveChangesAsync();
            return emp;
        }
    }
}
