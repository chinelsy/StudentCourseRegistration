using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentCourseEFcore.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; } 
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
