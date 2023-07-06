using Microsoft.EntityFrameworkCore;

namespace WebAPIWithEFCore.Data
{
    public class StudentDataContext:DbContext
    {
        public  DbSet<Student> students{ get; set; }
        public StudentDataContext()
        {

        }
        public StudentDataContext(DbContextOptions<StudentDataContext> dbContextOptions) : base(dbContextOptions) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=DESKTOP-PNAFED7\\SQLEXPRESS; initial catalogue=project; integrated security=SSPI; TrustServerCertificate= True;");
        }
    }
}
