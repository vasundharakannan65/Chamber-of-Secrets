using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practise1DA.models
{
    [Table("Salary")]
    public partial class Salary
    {
        [Key]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        [Column("Provident_FundId")]
        public int? ProvidentFundId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Basic { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Allowance { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Tax { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GrossSalary { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? NetSalary { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Salaries")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(ProvidentFundId))]
        [InverseProperty("Salaries")]
        public virtual ProvidentFund ProvidentFund { get; set; }
    }
}
