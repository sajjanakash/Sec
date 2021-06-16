using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace JWTAuthApi2.Model
{
    [Table("DEPARTMENT")]
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Column("departmentid")]
        public int Departmentid { get; set; }
        [Column("departmentName")]
        [StringLength(20)]
        public string DepartmentName { get; set; }
        [Column("location")]
        [StringLength(20)]
        public string Location { get; set; }

        [InverseProperty(nameof(Employee.Department))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
