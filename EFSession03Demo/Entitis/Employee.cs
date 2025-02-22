using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSession03Demo.Entitis
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime HiriginDate { get; set; } = DateTime.Now;
        public int DeptId { get; set; }
        public Department WorkFor { get; set; }
    }
}
