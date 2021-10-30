using Microsoft.EntityFrameworkCore;
using StudentCourseEFcore.Interface.Repository;
using StudentCourseEFcore.Models;

namespace StudentCourseEFcore.Repository
{
    public class StudentRepository: Repository<Student>, IStudentRepository
    {
        private readonly DbContext _context;

        public StudentRepository(DbContext context): base(context)
        {
            _context = context;
        }

      
    }
}
