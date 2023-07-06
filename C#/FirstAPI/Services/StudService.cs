using FirstAPI.Models;

namespace FirstAPI.Services
{
    public class StudService : IStudServices
    {
        private static List<Student> studentsList = new List<Student>
            {
                new Student{StudId = 1,Name="Raja",City="Tirunelveli", Pin=627007},
                new Student{StudId = 2,Name="Mathi",City="Tirunelveli", Pin=627007},
                new Student{StudId = 3,Name="Laxmeesh",City="Tirunelveli", Pin=627007},
            };
        public List<Student> GetAllStudDetail()
        {
            return studentsList;
        }
           
    }
    
}
