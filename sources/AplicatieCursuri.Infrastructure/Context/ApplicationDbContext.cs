using AplicatieCursuri.Core.Entities;
using AplicatieCursuri.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AplicatieCursuri.Server.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        //tabelele bazei de date

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parents> Parents { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }


        //Această metodă este folosită pentru a configura modelul bazei de date atunci când DbContext este creat. Este locul unde poți defini relațiile, cheile primare, cheile externe și alte constrângeri ale bazei de date
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);

            // Relația 1 la 1 între ApplicationUser și Teacher
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relația 1 la 1 între ApplicationUser și Student
            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relația 1 la 1 între ApplicationUser și Parents
            modelBuilder.Entity<Parents>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relația 1 la M între Teacher și Course
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relația M la M între Student și Course
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithMany(s => s.Courses)
                .UsingEntity(j => j.ToTable("StudentCourses"));

            // Relația 1 la M între Grades și Student/Course
            modelBuilder.Entity<Grades>()
                .HasOne(g => g.student)
                .WithMany()
                .HasForeignKey(g => g.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grades>()
                .HasOne(g => g.Course)
                .WithMany()
                .HasForeignKey(g => g.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
