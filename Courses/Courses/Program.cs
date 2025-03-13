using System.ComponentModel.DataAnnotations;
using Courses.DbContexts;
using Courses.Models;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************  Hello In My New App  ********************");
            Console.WriteLine("Choose What You Want\n1 : AddCourseToStudent\n2 : Remove Student");
            int Input; int.TryParse(Console.ReadLine(),out Input);
            if (Input==1)
            {
                StudentCourses studentCourses= new StudentCourses();
                studentCourses.AddStudentCourse();
            }
          


        }
    }
}
