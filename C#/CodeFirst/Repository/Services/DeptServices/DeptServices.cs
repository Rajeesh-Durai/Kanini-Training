using Microsoft.EntityFrameworkCore;
using ThirdAPI.Models;

namespace ThirdAPI.Repository.Services.DeptServices
{
    public class DeptServices : IDeptServices
    {
        public CompanyContext _companyContext;
        public DeptServices(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }
        public async Task<IEnumerable<Dept>> GetDepts()
        {
            return await _companyContext.Depts.ToListAsync();

        }
        public async Task<Dept>? GetDept(int id)
        {
            var dept = await _companyContext.Depts.FindAsync(id);
            return dept;
        }
        public async Task<Dept> PutDept(int id, Dept dept)
        {
            var item = await _companyContext.Depts.FindAsync(id);

            item.DeptNo = dept.DeptNo;
            item.DeptName = dept.DeptName;
            await _companyContext.SaveChangesAsync();
            return dept;

        }
        public async Task<List<Dept>> PostDept(Dept dept)
        {
            await _companyContext.Depts.AddAsync(dept);
            await _companyContext.SaveChangesAsync();
            return await _companyContext.Depts.ToListAsync();
        }
        public async Task<Dept>? DeleteDept(int id)
        {
            var dept = await _companyContext.Depts.FindAsync(id);
            _companyContext.Depts.Remove(dept);
            await _companyContext.SaveChangesAsync();
            return dept;

        }
    }
}
