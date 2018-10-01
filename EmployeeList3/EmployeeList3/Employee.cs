using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList3
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I, " + firstName + " " +
                lastName + ", do hereby Quit!");
        }
    }
}
