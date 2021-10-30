using StudentCourseEFcore.Interface.Repository;
using StudentCourseEFcore.Models;
using StudentCourseEFcore.Models.ViewModels.CourseViewModels;
using StudentCourseEFcore.Service.Interfaces;
using StudentCourseEFcore.UOW;
using System;
using System.Linq;

namespace StudentCourseEFcore.Service.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICourseRepository _courseRepository;

        public CourseService(IUnitOfWork unitOfWork, ICourseRepository courseRepository)
        {
            _unitOfWork = unitOfWork;
            _courseRepository = courseRepository;
        }

        public void AddCourse(AddCourseViewModel model)
        {
            try
            {
                var course = new Course
                {
                    CourseCode = model.CourseCode,
                    CourseName = model.CourseName

                };

                // _courseRepository.Add(result);
                _unitOfWork.Course.Add(course);
                _unitOfWork.SaveChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public Course DeleteCourse(DeleteCourseViewModel model)
        {
            try
            {
                var result = _unitOfWork.Course.Get(model.StudentId, model.CourseCode);
                _unitOfWork.Course.Delete(result);
                _unitOfWork.SaveChanges();
                Console.WriteLine($"Course associated with Student : {model.StudentId} and {model.CourseCode} has be deleted successful.");
                return result;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return null;
        }

        public Course DropCourse(DropCourseViewModel model)
        {
            try
            {
                //get a student id. //get a course code
                var result = _unitOfWork.Course.Get(model.StudentId, model.CourseCode);
                if (model.CourseCode == null)
                {
                    Console.WriteLine("This course code does not exist");

                }
                else
                {
                    result = _courseRepository.Find(c => c.CourseId == model.StudentId).FirstOrDefault();
                    _unitOfWork.Course.Delete(result);
                    _unitOfWork.SaveChanges();
                    Console.WriteLine($"Course associated with Student : {model.StudentId} and {model.CourseCode} has be Drop successful.");
                    return result;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return null;
            //check that course code actually belongs to an exisiting course
            //get the cousre with the corresponding course code nd get its Id
            //get a studentCourse entity where courseid and studentid == model.courseId and studentid
            //if we dont find it give an error
            //Wen we find it, we will delete it from the system
            //Save changes.......
        }

        public void RegisterCourse(RegisterCourseViewModel model)
        {
            try
            {
                var result = _unitOfWork.Course.Get(model.StudentId, model.CourseCode);
                var student = model.StudentId;
                var course = model.CourseCode;
                if (student == model.StudentId && course == model.CourseCode)
                {
                    _unitOfWork.Course.Add(result);
                    _unitOfWork.SaveChanges();
                    Console.WriteLine($"Course associated with Student : {model.StudentId} and {model.CourseCode} has be Registered successfully.");
                }
                else
                {
                    Console.WriteLine($"Course associated with Student : {model.StudentId} and {model.CourseCode} failed to Register.");

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            //get a student id
            //get a course code
            //check that student id actually belongs to an exisiting student
            //check that course code actually belongs to an exisiting course
            //get the cousre with the corresponding course code nd get its Id
            //create a new student Course class using the student id an cousreId
            //Save changes.......
        }

        public void UpdateCourse(UpdateCourseViewModel model)
        {
            try
            {
                var result = _courseRepository.Find(c => c.CourseCode == model.CourseName).FirstOrDefault();
                if (result != null)
                {
                    result.CourseCode = model.NewCourseCode;
                    result.CourseName = model.NewCourseName;
                    _courseRepository.Update(result);
                    _unitOfWork.SaveChanges();
                    Console.WriteLine($"The above course with the following course code and name {model.CourseCode} and {model.CourseName}");
                }
                else
                {
                    Console.WriteLine("Course failed to Update.");

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            //get course code
            //use the course code to get a courseName
            //update what we want to update
            //Save changes.......
            // if newcoursename is null, let coursename == coursename
            // if newcoursecode is null, let coursecode == coursecode
        }
    }
}
