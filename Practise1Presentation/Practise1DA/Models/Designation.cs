using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practise1DA.models
{
    [Table("Designation")]
    public partial class Designation
    {
        public Designation()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Column("createdAt", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("modifiedAt", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDraft { get; set; }

        [InverseProperty(nameof(Employee.Designation))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
