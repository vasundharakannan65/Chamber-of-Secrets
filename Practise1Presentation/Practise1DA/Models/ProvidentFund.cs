using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practise1DA.models
{
    [Table("Provident_Fund")]
    public partial class ProvidentFund
    {
        public ProvidentFund()
        {
            Salaries = new HashSet<Salary>();
        }

        [Key]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        [Column("PFAmount", TypeName = "decimal(18, 0)")]
        public decimal Pfamount { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("ProvidentFunds")]
        public virtual Employee Employee { get; set; }
        [InverseProperty(nameof(Salary.ProvidentFund))]
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
