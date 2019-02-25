using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDept_DAL.DataConnection;
using EmployeeDept_DAL.Entity.Employee;

namespace EmployeeDept_DAL.DataConnection
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<Department> Departments { get; set; }

    }
}
