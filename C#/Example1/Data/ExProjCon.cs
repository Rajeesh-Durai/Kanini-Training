using Example1.Models;
using Microsoft.EntityFrameworkCore;

namespace Example1.Data
{
    public class ExProjCon:DbContext
    {
        public ExProjCon(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Users> users { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Groups> groups { get; set; }
    }
}
