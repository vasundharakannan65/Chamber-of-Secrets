using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practise1DA.models
{
    [Table("Employee")]
    public partial class Employee
    {
        public Employee()
        {
            EmployeeAddresses = new HashSet<EmployeeAddress>();
            ProvidentFunds = new HashSet<ProvidentFund>();
            Salaries = new HashSet<Salary>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string EmailId { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime JoiningDate { get; set; }
        public int? DesignationId { get; set; }
        public int? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty("Employees")]
        public virtual Department Department { get; set; }
        [ForeignKey(nameof(DesignationId))]
        [InverseProperty("Employees")]
        public virtual Designation Designation { get; set; }
        [InverseProperty(nameof(EmployeeAddress.Employee))]
        public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        [InverseProperty(nameof(ProvidentFund.Employee))]
        public virtual ICollection<ProvidentFund> ProvidentFunds { get; set; }
        [InverseProperty(nameof(Salary.Employee))]
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
