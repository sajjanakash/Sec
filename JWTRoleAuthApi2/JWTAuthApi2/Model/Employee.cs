using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace JWTAuthApi2.Model
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column("employeeId")]
        public int EmployeeId { get; set; }
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("designation")]
        [StringLength(20)]
        public string Designation { get; set; }
        [Column("address")]
        [StringLength(20)]
        public string Address { get; set; }
        [Column("dateofjoining", TypeName = "date")]
        public DateTime? Dateofjoining { get; set; }
        [Column("departmentid")]
        public int? Departmentid { get; set; }
        [Column("salary", TypeName = "numeric(18, 2)")]
        public decimal? Salary { get; set; }

        [ForeignKey(nameof(Departmentid))]
        [InverseProperty("Employees")]
        public virtual Department Department { get; set; }
    }
}
