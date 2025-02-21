using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSession02.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public Employee? Manager { get; set; }
    }
}
