using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDept_DAL.Entity.Employee
{
    public class Department
    {
        [Key]
        [Display(Name = "")]
        public string DepartmentId { get; set; }

        [Display(Name = "")]
        public string Description { get; set; }

        [Display(Name = "")]
        public int SeqNo { get; set; }
    }
}
