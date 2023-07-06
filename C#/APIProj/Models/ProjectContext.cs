using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIProj.Models;

public partial class ProjectContext : DbContext
{
    public ProjectContext()
    {

    }

    public ProjectContext(DbContextOptions<ProjectContext> options)
        : base(options)
    {

    }

    public virtual DbSet<BookingDetaill> BookingDetaills { get; set; }


    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<ShowTime> ShowTimes { get; set; }

    public virtual DbSet<Theatre> Theatres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
   //     => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = project; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingDetaill>(entity =>
        {
            entity.HasKey(e => e.BookingDate).HasName("PK__Booking___0129EF2C829BA166");

            entity.ToTable("Booking_Detaills");

            entity.Property(e => e.BookingDate)
                .HasColumnType("date")
                .HasColumnName("booking_date");
            entity.Property(e => e.LoginId).HasColumnName("Login_Id");
            entity.Property(e => e.MovieId).HasColumnName("movie_id");
            entity.Property(e => e.SeatId).HasColumnName("seat_id");
            entity.Property(e => e.TheatreId).HasColumnName("theatre_id");

            

            entity.HasOne(d => d.Movie).WithMany(p => p.BookingDetaills)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Booking_Detaills_fk1");

            entity.HasOne(d => d.Seat).WithMany(p => p.BookingDetaills)
                .HasForeignKey(d => d.SeatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Booking_Detaills_fk3");

            entity.HasOne(d => d.Theatre).WithMany(p => p.BookingDetaills)
                .HasForeignKey(d => d.TheatreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Booking_D__theat__5BE2A6F2");
        });

       

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("PK_MOVIES");

            entity.Property(e => e.MovieId)
                .ValueGeneratedNever()
                .HasColumnName("movie_id");
            entity.Property(e => e.MovieLang)
                .HasMaxLength(20)
                .HasColumnName("movie_lang");
            entity.Property(e => e.MovieName)
                .HasMaxLength(20)
                .HasColumnName("movie_name");
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.SeatId).HasName("PK_SEAT");

            entity.ToTable("Seat");

            entity.Property(e => e.SeatId)
                .ValueGeneratedNever()
                .HasColumnName("seat_id");
            entity.Property(e => e.SeatStatus)
                .HasMaxLength(20)
                .HasColumnName("seat_status");
            entity.Property(e => e.SeatType).HasColumnName("seat_type");
            entity.Property(e => e.TicketPrice).HasColumnName("ticket_price");
        });

        modelBuilder.Entity<ShowTime>(entity =>
        {
            entity.HasKey(e => e.ShowId).HasName("PK_SHOW_TIME");

            entity.ToTable("Show_Time");

            entity.Property(e => e.ShowId)
                .ValueGeneratedNever()
                .HasColumnName("show_id");
            entity.Property(e => e.ShowTime1)
                .HasMaxLength(20)
                .HasColumnName("show_time");
        });

        modelBuilder.Entity<Theatre>(entity =>
        {
            entity.HasKey(e => e.TheatreId).HasName("PK_THEATRE");

            entity.ToTable("Theatre");

            entity.Property(e => e.TheatreId)
                .ValueGeneratedNever()
                .HasColumnName("theatre_id");
            entity.Property(e => e.MovieId).HasColumnName("movie_id");
            entity.Property(e => e.SeatId).HasColumnName("seat_id");
            entity.Property(e => e.ShowId).HasColumnName("show_id");
            entity.Property(e => e.TheatreArea)
                .HasMaxLength(20)
                .HasColumnName("theatre_area");
            entity.Property(e => e.TheatreName)
                .HasMaxLength(20)
                .HasColumnName("theatre_name");

            entity.HasOne(d => d.Movie).WithMany(p => p.Theatres)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Theatre__movie_i__571DF1D5");

            entity.HasOne(d => d.Seat).WithMany(p => p.Theatres)
                .HasForeignKey(d => d.SeatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Theatre__seat_id__5812160E");

            entity.HasOne(d => d.Show).WithMany(p => p.Theatres)
                .HasForeignKey(d => d.ShowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Theatre__show_id__59063A47");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
