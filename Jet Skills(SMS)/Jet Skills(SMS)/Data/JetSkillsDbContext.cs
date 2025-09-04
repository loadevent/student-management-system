using System;
using System.Collections.Generic;
using Jet_Skills_SMS_.Models;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Data;

public partial class JetSkillsDbContext : DbContext
{
    public JetSkillsDbContext()
    {
    }

    public JetSkillsDbContext(DbContextOptions<JetSkillsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AllUser> AllUsers { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Lecturer> Lecturers { get; set; }

    public virtual DbSet<LecturerModule> LecturerModules { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK_Admins_1");
        });

        modelBuilder.Entity<AllUser>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Email }).HasName("PK_Users");

            entity.HasOne(d => d.UserTypeNavigation).WithMany(p => p.AllUsers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Users_UserType");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__8F1EF7AE1FFFE39B");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Courses).HasConstraintName("FK__Courses__faculty__29572725");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__Enrollme__6D24AA7A6F9440BB");

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments).HasConstraintName("FK__Enrollmen__cours__33D4B598");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments).HasConstraintName("FK__Enrollmen__stude__32E0915F");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.FacultyId).HasName("PK__Facultie__7B00413C756BCC2F");
        });

        modelBuilder.Entity<Lecturer>(entity =>
        {
            entity.HasKey(e => e.LecturerId).HasName("PK__Lecturer__D4D1DAB1C199F4FB");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Lecturers).HasConstraintName("FK__Lecturers__facul__300424B4");

            entity.HasOne(d => d.UserTypeNavigation).WithMany(p => p.Lecturers).HasConstraintName("FK__Lecturers__user___4AB81AF0");
        });

        modelBuilder.Entity<LecturerModule>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__Lecturer__DA8918149D103725");

            entity.HasOne(d => d.Lecturer).WithMany(p => p.LecturerModules).HasConstraintName("FK__LecturerM__lectu__37A5467C");

            entity.HasOne(d => d.Module).WithMany(p => p.LecturerModules).HasConstraintName("FK__LecturerM__modul__36B12243");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__Modules__1A2D0653F91B8B21");

            entity.HasOne(d => d.Course).WithMany(p => p.Modules).HasConstraintName("FK__Modules__course___2C3393D0");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__2A33069AB3CD0E19");

            entity.HasOne(d => d.UserTypeNavigation).WithMany(p => p.Students).HasConstraintName("FK__Students__user_t__49C3F6B7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
