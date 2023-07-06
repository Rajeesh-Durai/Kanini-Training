using KaniniProjectAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KaniniProjectAPI.Data
{
    public class KaniniDbContext:DbContext
    {
        public KaniniDbContext(DbContextOptions<KaniniDbContext> options) : base(options){ }
        public DbSet<EmployeeDepartment>? EmployeeDepartments { get; set; }
        public DbSet<UserAssessment>? UserAssessments { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Assessment>? Assessments { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Topic>? Topics { get; set; }
        public DbSet<Skill>? Skills { get; set; }
        public DbSet<AddQuestion>? AddQuestions { get; set; }
        public DbSet<EmailHistory>? EmailHistory { get; set; }
        public DbSet<QuestionPage>? QuestionPages { get; set; }
        public DbSet<QuestionType>? QuestionTypes { get; set; }

    }
}
