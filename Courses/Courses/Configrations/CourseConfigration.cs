using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Courses.Configrations
{
    internal class CourseConfigration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            
           

            builder.Property(C => C.CourseName)
                   .HasColumnName("NameOfCourse")
                   .HasColumnType("varchar")
                   .IsRequired();
        }
    }
}
