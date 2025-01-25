using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public double salary { get; set; }

        public override string ToString()
        {
            return $"Id: {id}, Name: {name}, Age: {age}, Salary: {salary}";
        }
    }
}
