using StudentCourseEFcore.DataContext;
using StudentCourseEFcore.Interface.Repository;
using StudentCourseEFcore.Repository;
using System.Threading.Tasks;

namespace StudentCourseEFcore.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentCourseDbContext _studentCourseDbContext;
        private IStudentRepository _studentRepository;
        private ICourseRepository _courseRepository;
        public UnitOfWork(StudentCourseDbContext studentCourseDbContext)
        {
            _studentCourseDbContext = studentCourseDbContext;


        }
        public IStudentRepository Student
        {
            get
            {
                if (_studentRepository == null)
                    _studentRepository = new StudentRepository(_studentCourseDbContext);
                return _studentRepository;
            }
        }


        public ICourseRepository Course
        {
            get
            {
                if (_courseRepository == null)
                    _courseRepository = new CourseRepository(_studentCourseDbContext);
                return _courseRepository;
            }
        }
        public int SaveChanges()
        {
            return _studentCourseDbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _studentCourseDbContext.SaveChangesAsync();
        }
    }
}
