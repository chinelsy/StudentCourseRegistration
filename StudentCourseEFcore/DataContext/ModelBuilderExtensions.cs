using Microsoft.EntityFrameworkCore;
using StudentCourseEFcore.Models;

namespace StudentCourseEFcore.DataContext
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var stud1 = new Student
            {
                StudentId = 1,
                LastName = "Dike",
                FirstName = "Chikki",
                Department = "Botany",
                RegNo = "2010/145354"
            };
            var stud2 = new Student
            {
                StudentId = 2,
                LastName = "Agu",
                FirstName = "Jikki",
                Department = "Zoology",
                RegNo = "2011/235354"
            };
            var stud3 = new Student
            {
                StudentId = 3,
                LastName = "Uzoh",
                FirstName = "Ego",
                Department = "Animal sci",
                RegNo = "2014/145355"
            };
            modelBuilder.Entity<Student>().HasData(stud1, stud2, stud3);

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseName = "Life Biology", CourseCode = "Bio 101" },
                new Course { CourseId = 2, CourseName = "Modern Physics", CourseCode = "Phy 101" },
                new Course { CourseId = 3, CourseName = "Biotechnology", CourseCode = "BioTech 101" },
                new Course { CourseId = 4, CourseName = "English", CourseCode = "Eng 101" },
                new Course { CourseId = 5, CourseName = "Physical Chemistry", CourseCode = "Chem 101" }
                );


            modelBuilder.Entity<StudentCourse>().HasData(
            new StudentCourse { CourseId = 1, StudentId = 1 },
            new StudentCourse { CourseId = 1, StudentId = 2 },
            new StudentCourse { CourseId = 1, StudentId = 3 },
            new StudentCourse { CourseId = 2, StudentId = 1 },
            new StudentCourse { CourseId = 2, StudentId = 2 },
            new StudentCourse { CourseId = 2, StudentId = 3 },
            new StudentCourse { CourseId = 3, StudentId = 1 },
            new StudentCourse { CourseId = 3, StudentId = 2 },
            new StudentCourse { CourseId = 3, StudentId = 3 },
            new StudentCourse { CourseId = 4, StudentId = 1 },
            new StudentCourse { CourseId = 4, StudentId = 2 },
            new StudentCourse { CourseId = 4, StudentId = 3 },
            new StudentCourse { CourseId = 5, StudentId = 1 },
            new StudentCourse { CourseId = 5, StudentId = 2 },
            new StudentCourse { CourseId = 5, StudentId = 3 }
            );



        }
    }
}
