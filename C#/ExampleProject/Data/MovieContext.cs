using ExampleProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ExampleProject.Data
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }
        public DbSet<Login> logins { get; set; }
        public DbSet<MovieDetails> movieDetails { get; set; }
        public DbSet<ScreenDetails> screenDetails { get; set; }
        public DbSet<BookingDetails> bookingDetails { get; set; }
    }
}
