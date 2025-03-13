using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Courses.Models;
using Microsoft.EntityFrameworkCore;

namespace Courses.DbContexts
{
    internal class CoursesDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = StudentCourses ; Trusted_Connection = true ; TrustServerCertificate = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Student>()
                        .HasOne(S => S.CourseNameOfStudent)
                        .WithMany(C => C.Students)
                        .HasForeignKey(C => C.CourseStudentId);
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
