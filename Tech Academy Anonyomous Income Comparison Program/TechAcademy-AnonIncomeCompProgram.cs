using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly wage: ");
            int hourlyWage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter # hours worked per week: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of person 1: $"+ hourlyWage * hoursWorked * 52);
            int weeklyWage = hourlyWage * hoursWorked;

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly wage: ");
            int hourlyWage2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter # hours worked per week: ");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of person 2: $" + hourlyWage2 * hoursWorked2 * 52);
            int weeklyWage2 = hourlyWage2 * hoursWorked2;

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (weeklyWage > weeklyWage2)
            {
                Console.WriteLine("Yes, Person 1 makes more money.");
            }
            else
            {
                Console.WriteLine("No, Person 2 makes more money.");
            }
            Console.ReadKey();
                        
        }
    }
}
