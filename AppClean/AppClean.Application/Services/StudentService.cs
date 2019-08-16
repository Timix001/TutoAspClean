using AppClean.Application.Interfaces;
using AppClean.Application.ViewModels;
using AppClean.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppClean.Application.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentService(IStudentRepository courseRepository)
        {
            _studentRepository = courseRepository;
        }
        public StudentsViewModel GetStudents()
        {
            return new StudentsViewModel() {
                Students = _studentRepository.GetStudents()
            };

        }
    }
}
