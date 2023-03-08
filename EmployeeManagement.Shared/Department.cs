using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Shared
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmenteName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
