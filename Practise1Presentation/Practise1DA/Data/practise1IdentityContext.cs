using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Practise1DA.models;

#nullable disable

namespace Practise1DA.data
{
    public partial class practise1IdentityContext : DbContext
    {
        public practise1IdentityContext(DbContextOptions<practise1IdentityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<ProvidentFund> ProvidentFunds { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }

        
    }
}
