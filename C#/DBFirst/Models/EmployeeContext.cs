using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SecAPI.Models;

public partial class EmployeeContext : DbContext
{
    public EmployeeContext()
    {
    }

    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PKDept");

            entity.ToTable("dept");

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("deptno");
            entity.Property(e => e.Dname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dname");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Eno).HasName("PKEmp");

            entity.ToTable("emp");

            entity.Property(e => e.Eno)
                .ValueGeneratedNever()
                .HasColumnName("eno");
            entity.Property(e => e.Deptno).HasColumnName("deptno");
            entity.Property(e => e.Desig)
                .HasMaxLength(20)
                .HasColumnName("desig");
            entity.Property(e => e.Ename)
                .HasMaxLength(25)
                .HasColumnName("ename");
            entity.Property(e => e.Ph).HasColumnName("ph");

            entity.HasOne(d => d.DeptnoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Deptno)
                .HasConstraintName("FK_EMP_Dept");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
