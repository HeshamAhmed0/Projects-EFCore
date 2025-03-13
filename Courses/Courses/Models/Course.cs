using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
      
        public ICollection<Student> Students { get; set; }
    }
}
