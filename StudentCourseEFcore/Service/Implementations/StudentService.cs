using StudentCourseEFcore.Interface.Repository;
using StudentCourseEFcore.Models;
using StudentCourseEFcore.Models.ViewModels.StudentViewModels;
using StudentCourseEFcore.Service.Interfaces;
using StudentCourseEFcore.UOW;
using System;
using System.Linq;

namespace StudentCourseEFcore.Service.Implementations
{
    public class StudentService : IStudentService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentRepository _studentRepository;

        public StudentService(IUnitOfWork unitOfWork, IStudentRepository studentRepository)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = studentRepository;
        }
        public void AddStudent(AddStudentViewModel model)
        {
            try
            {
                var student = new Student
                {
                    LastName = model.LastName,
                    FirstName = model.FirstName,
                    Department = model.Department,
                    RegNo = model.RegNo
                };
                _studentRepository.Add(student);
                _unitOfWork.SaveChanges();
                Console.WriteLine("Student Registered successfully");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(error.InnerException);
            }
        }

        public Student DeleteStudent(DeleteStudentViewModel model)
        {
            try
            {
                var result = _unitOfWork.Student.Get(model.StudentId, model.RegNo);
                _unitOfWork.Student.Delete(result);
                _unitOfWork.SaveChanges();
                Console.WriteLine($"Student : {model.StudentId} {model.RegNo} has been deleted\n\n");
                return result;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return null;
        }

        public void GetStudent(int id, string RegNo)
        {
            try
            {
                var result = _studentRepository.Get(id, RegNo);
                Console.WriteLine(result.StudentId);
                Console.WriteLine(result.RegNo);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void LogInStudent(LogInStudentViewModel model)
        {
            model.UserName = model.UserName.Trim().ToLower();
            model.Password = model.Password.Trim().ToLower();
            if (model.UserName == model.UserName && model.Password == model.Password)
            {
                Console.WriteLine($"Student logged in successfully.");
            }
            else
            {
                Console.WriteLine("Invalid Username or password\n");
            }
        }

        public void LogOutStudent(LogOutStudentViewModel model)
        {
            model.UserName = model.UserName.Trim().ToLower();
            model.Password = model.Password.Trim().ToLower();
            if (model.UserName == model.UserName && model.Password == model.Password)
            {
                Console.WriteLine($"Student has logged out successfully.");
            }
            else
            {
                Console.WriteLine("Logged out failed");
            }
        }

        public void UpdateStudent(UpdateStudentViewModel model)
        {
            try
            {
                var result = _studentRepository.Find(s => s.RegNo == model.RegNo).FirstOrDefault();
                if (result != null)
                {
                    result.RegNo = model.RegNo;
                    _studentRepository.Update(result);
                    _unitOfWork.SaveChanges();
                    Console.WriteLine("student current year of study has been updated");
                }
                else
                {
                    Console.WriteLine("failed to Update.");

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
