using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employees = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            employees.SayName();

        }
    }
}
