using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Jet_Skills_SMS_.Models;

public partial class JetSkillsDbContext : DbContext
{
    public JetSkillsDbContext()
    {
    }

    public JetSkillsDbContext(DbContextOptions<JetSkillsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Lecturer> Lecturers { get; set; }

    public virtual DbSet<LecturerModule> LecturerModules { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=JetSkillsDB;Trusted_Connection=True;MultipleActiveResultSets=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__8F1EF7AE1FFFE39B");

            entity.Property(e => e.CourseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("course_id");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("course_name");
            entity.Property(e => e.DurationYears).HasColumnName("duration_years");
            entity.Property(e => e.FacultyId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("faculty_id");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Courses)
                .HasForeignKey(d => d.FacultyId)
                .HasConstraintName("FK__Courses__faculty__29572725");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__Enrollme__6D24AA7A6F9440BB");

            entity.Property(e => e.EnrollmentId).HasColumnName("enrollment_id");
            entity.Property(e => e.CourseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("course_id");
            entity.Property(e => e.EnrollmentDate).HasColumnName("enrollment_date");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Enrollmen__cours__33D4B598");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Enrollmen__stude__32E0915F");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.FacultyId).HasName("PK__Facultie__7B00413C756BCC2F");

            entity.Property(e => e.FacultyId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("faculty_id");
            entity.Property(e => e.DeanName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dean_name");
            entity.Property(e => e.FacultyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("faculty_name");
        });

        modelBuilder.Entity<Lecturer>(entity =>
        {
            entity.HasKey(e => e.LecturerId).HasName("PK__Lecturer__D4D1DAB1C199F4FB");

            entity.HasIndex(e => e.Email, "UQ__Lecturer__AB6E61640D7E42F3").IsUnique();

            entity.Property(e => e.LecturerId).HasColumnName("lecturer_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FacultyId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("faculty_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.UserType).HasColumnName("user_type");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Lecturers)
                .HasForeignKey(d => d.FacultyId)
                .HasConstraintName("FK__Lecturers__facul__300424B4");

            entity.HasOne(d => d.UserTypeNavigation).WithMany(p => p.Lecturers)
                .HasForeignKey(d => d.UserType)
                .HasConstraintName("FK__Lecturers__user___4AB81AF0");
        });

        modelBuilder.Entity<LecturerModule>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__Lecturer__DA8918149D103725");

            entity.ToTable("LecturerModule");

            entity.Property(e => e.AssignmentId).HasColumnName("assignment_id");
            entity.Property(e => e.AcademicYear)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("academic_year");
            entity.Property(e => e.LecturerId).HasColumnName("lecturer_id");
            entity.Property(e => e.ModuleId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("module_id");

            entity.HasOne(d => d.Lecturer).WithMany(p => p.LecturerModules)
                .HasForeignKey(d => d.LecturerId)
                .HasConstraintName("FK__LecturerM__lectu__37A5467C");

            entity.HasOne(d => d.Module).WithMany(p => p.LecturerModules)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK__LecturerM__modul__36B12243");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__Modules__1A2D0653F91B8B21");

            entity.Property(e => e.ModuleId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("module_id");
            entity.Property(e => e.CourseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("course_id");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("module_name");
            entity.Property(e => e.Semester).HasColumnName("semester");

            entity.HasOne(d => d.Course).WithMany(p => p.Modules)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Modules__course___2C3393D0");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__2A33069AB3CD0E19");

            entity.HasIndex(e => e.Email, "UQ__Students__AB6E616418172070").IsUnique();

            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EnrollmentDate).HasColumnName("enrollment_date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.UserType).HasColumnName("user_type");

            entity.HasOne(d => d.UserTypeNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.UserType)
                .HasConstraintName("FK__Students__user_t__49C3F6B7");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.ToTable("UserType");

            entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
