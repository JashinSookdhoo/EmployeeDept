using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDept_DAL.Entity.Employee
{
    public class Employee
    {
        [Key]
        [Required(ErrorMessage ="Please enter an Employee ID")]
        [Display(Name = "Employee ID")]
        public string EmployeeId { get; set; }

        [Display(Name = "")]
        public string FirstName { get; set; }

        [Display(Name = "")]
        public string LastName { get; set; }

        [Display(Name = "")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

        [Display(Name = "")]
        public string Sex { get; set; }

        [Display(Name = "")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "")]
        public string DepartmentId { get; set; }

    }
}
