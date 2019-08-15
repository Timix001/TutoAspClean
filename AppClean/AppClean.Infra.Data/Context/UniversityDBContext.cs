using AppClean.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppClean.Infra.Data.Context
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext (DbContextOptions options) : base(options) { }
        public DbSet<Students> Students { get; set; }
    }
}
