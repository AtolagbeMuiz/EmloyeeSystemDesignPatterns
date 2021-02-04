using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeSystemDesignPatterns.Models.EmployeeModels;

namespace EmployeeSystemDesignPatterns.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext (DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeSystemDesignPatterns.Models.EmployeeModels.Employee> Employee { get; set; }
        public DbSet<EmployeeTypes> EmployeeTypes { get; set; }
    }
}
