using System;
using System.Collections.Generic;
using System.Text;

namespace AppClean.Domain.Models.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Students> GetStudents();
    }
}
