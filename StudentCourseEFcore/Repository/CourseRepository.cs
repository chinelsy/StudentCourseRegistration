using Microsoft.EntityFrameworkCore;
using StudentCourseEFcore.Interface.Repository;
using StudentCourseEFcore.Models;

namespace StudentCourseEFcore.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly DbContext _context;

        public CourseRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}
