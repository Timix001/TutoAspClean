using AppClean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppClean.Application.ViewModels
{
    public class StudentsViewModel
    {
        public IEnumerable<Students> Students { get; set; }
    }
}
