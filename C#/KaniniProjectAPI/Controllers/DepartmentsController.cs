using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KaniniProjectAPI.Data;
using KaniniProjectAPI.Models;
using KaniniProjectAPI.Services.Department_Services;

namespace KaniniProjectAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _context;

        public DepartmentsController(IDepartmentService context)
        {
            _context = context;
        }

        // GET: api/Departments
        [HttpGet("GetDepartment")]
        public async Task<ActionResult<List<Department>>> GetDepartments()
        {
            try
            {
                var get = await _context.GetDepartments();
                return Ok(get);
            }
            catch (ArithmeticException ex)
            {
                return NotFound(ex.Message);

            }
        }

        // POST: api/Departments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AddDepartment")]
        public async Task<ActionResult<Department>> AddDepartment(Department department)
        {
            try
            {
                var add = await _context.AddDepartment(department);
                return Ok(add);
            }
            catch (ArithmeticException ex)
            {
                return NotFound(ex.Message);

            }
        }

      /*  // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            if (_context.Departments == null)
            {
                return NotFound();
            }
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartmentExists(int id)
        {
            return (_context.Departments?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/
    }
}
