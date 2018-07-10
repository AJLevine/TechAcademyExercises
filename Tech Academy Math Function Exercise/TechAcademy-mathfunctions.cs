using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1=0;
            Console.WriteLine("Enter a number to receive the number times 50: ");
            number1  = Convert.ToDouble(Console.ReadLine());
            number1 = number1 * 50;
            Console.WriteLine(number1);

            int number2=0;
            Console.WriteLine("Enter a number to receive the number plus 25: ");
            number2= Convert.ToInt32(Console.ReadLine());
            number2 = number2 + 25;
            Console.WriteLine(number2);

            double number3=0;
            Console.WriteLine("Enter a number to receive the number divided by 12.5: ");
            number3= Convert.ToDouble(Console.ReadLine());
            number3 = number3/12.5;
            Console.WriteLine(number3);

            int number4=0;
            Console.WriteLine("Enter a number to determine if it is greater than 50 (T/F): ");
            number4 = Convert.ToInt32(Console.ReadLine()); ;
            if (number4>=50)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            int number5=0;
            Console.WriteLine("Enter a number to determine the remainder after it is divided by 7: ");
            number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number5 % 7);
            Console.ReadKey();

        }
    }
}
