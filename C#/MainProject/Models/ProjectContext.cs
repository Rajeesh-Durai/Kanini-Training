

using Microsoft.EntityFrameworkCore;

namespace MainProject.Models
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }
        public DbSet<User> Users { get; set; }

    }
}
