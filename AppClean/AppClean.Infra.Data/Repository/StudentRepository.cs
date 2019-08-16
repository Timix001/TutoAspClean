using AppClean.Domain.Models;
using AppClean.Domain.Models.Interfaces;
using AppClean.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppClean.Infra.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private UniversityDBContext _ctx;

        public StudentRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Students> GetStudents()
        {
            return _ctx.Students;
        }
    }
}
