using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Courses.DbContexts;
using Courses.Models;

namespace Courses
{
    internal class StudentCourses
    {
        public void AddStudentCourse()
        {
            CoursesDbContext coursesDbContext = new CoursesDbContext();
           
            Console.Write("Enter Student Name : ");
            string  Name = Console.ReadLine();
            Console.Write("Enter Student Course : ");
            string  StudentCourse = Console.ReadLine();
            
            Student NewStudent = new Student()
            {
                StudentName = Name,
                CourseNameOfStudent=new Course
                {
                    CourseName=StudentCourse,
                },
               
            };
            //Console.Write("Enter Course Name : ");
            //Name = Console.ReadLine();
            //Course NewCourse = new Course()
            //{
               
            //    CourseName = Name
            //};

            coursesDbContext.Students.Add(NewStudent);
            //coursesDbContext.Courses.Add(NewCourse);
            coursesDbContext.SaveChanges();
        }
    }
}
