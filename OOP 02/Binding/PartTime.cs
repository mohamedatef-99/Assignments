using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02.Binding
{
    internal class PartTime : Employee
    {
        
        public double HoureRate { get; set; }
        public double NumberOfHours { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("I am part time Employee");
        }

        public override void Fun02()
        {
            Console.WriteLine($"Salary: {HoureRate * NumberOfHours}");
        }
    }
}
