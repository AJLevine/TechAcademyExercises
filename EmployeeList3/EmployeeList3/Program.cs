using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList3
{
    class Program
    {

        static void Main(string[] args)
        {
            IQuittable name = new Employee();
            Employee employees = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            employees.SayName();
            name.Quit();

        }
    }
}
