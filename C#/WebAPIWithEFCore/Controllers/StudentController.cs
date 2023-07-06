using WebAPIWithEFCore.Services.StudentServices;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIWithEFCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       private readonly IStudServices _studService;
        public StudentController(IStudServices studService)
        {
            _studService = studService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudDetail()
        {
           return _studService.GetAllStudDetail();
            
        }
       /* [HttpGet]
        [Route("(StudId)")]
        public async Task<ActionResult<List<Student>>> GetStuDetById(int studId)
        {
            var student=studentsList.Where(s => s.StudId == studId).FirstOrDefault();
            if(student == null)
            {
                return NotFound("Student Id is not found");
            }
            return Ok(student);
        }
        [HttpPost]
        public async Task<ActionResult<List<Student>>>AddStuDetail()
        {
            var stud = new Student { StudId = 4, Name = "Rajnesh", City = "Tirunelveli", Pin = 627007 };
            studentsList.Add(stud);
            return Ok(studentsList);
        }
        public async Task<ActionResult<List<Student>>> AddStudDetail(Student stud)
        {
            studentsList.Add(stud);
            return Ok(studentsList);
        }
        /*[HttpDelete]
        public async Task<ActionResult> DelStuDet()
        {
            
          foreach(var stud in studentsList)
            {
                studentsList.Remove(stud);
            }
            return Ok(studentsList);
        }*/

    }
}
