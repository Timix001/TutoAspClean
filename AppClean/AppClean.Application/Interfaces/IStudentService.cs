using AppClean.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppClean.Application.Interfaces
{
    public interface IStudentService
    {
        StudentsViewModel GetStudents();
    }
}
