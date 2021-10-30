using StudentCourseEFcore.Models;
using StudentCourseEFcore.Models.ViewModels.CourseViewModels;

namespace StudentCourseEFcore.Service.Interfaces
{
    public interface ICourseService
    { 
        void AddCourse(AddCourseViewModel model);
       Course DeleteCourse(DeleteCourseViewModel model);
        Course DropCourse(DropCourseViewModel model);
        void RegisterCourse(RegisterCourseViewModel model);
        void UpdateCourse(UpdateCourseViewModel model);
    }
}
