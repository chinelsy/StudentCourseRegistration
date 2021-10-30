using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentCourseEFcore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
        public string RegNo { get; set; } 
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
