using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practise1DA.models
{
    [Table("Employee_Address")]
    public partial class EmployeeAddress
    {
        [Key]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string AddressLine1 { get; set; }
        [Required]
        [StringLength(100)]
        public string AddressLine2 { get; set; }
        [Required]
        [StringLength(60)]
        public string City { get; set; }
        [Required]
        [StringLength(6)]
        public string PostalCode { get; set; }
        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("EmployeeAddresses")]
        public virtual Employee Employee { get; set; }
    }
}
