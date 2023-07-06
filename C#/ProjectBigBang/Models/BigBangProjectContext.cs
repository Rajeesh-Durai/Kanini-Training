using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectBigBang.Models;

public partial class BigBangProjectContext : DbContext
{
    public BigBangProjectContext()
    {
    }

    public BigBangProjectContext(DbContextOptions<BigBangProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog =BigBangProject; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC07A2A04346");

            entity.ToTable("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
