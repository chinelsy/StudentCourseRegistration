using StudentCourseEFcore.Models;
using StudentCourseEFcore.Models.ViewModels.StudentViewModels;

namespace StudentCourseEFcore.Service.Interfaces
{
    public interface IStudentService
    {
        Student DeleteStudent(DeleteStudentViewModel model);//Admin
        //void GetStudent(GetStudentViewModel model);//Admin
        void LogInStudent(LogInStudentViewModel model);
        void LogOutStudent(LogOutStudentViewModel model);
        void AddStudent(AddStudentViewModel model);//Admin
        void UpdateStudent(UpdateStudentViewModel model);
    }
}
