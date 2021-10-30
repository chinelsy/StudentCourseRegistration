using StudentCourseEFcore.Interface.Repository;
using System.Threading.Tasks;

namespace StudentCourseEFcore.UOW
{
    public interface IUnitOfWork
    {
        IStudentRepository Student { get; }
        ICourseRepository Course { get; }
        int SaveChanges();
        Task <int> SaveChangesAsync();  
    }
}
