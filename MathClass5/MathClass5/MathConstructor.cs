using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass5
{
    //1.Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.
    class MathConstructor
    {
        public void DivideByTwo(int numberOne)
        {
            numberOne = numberOne / 2;

            Console.WriteLine(numberOne);
        }

        public void DivideByTwo(double numberOne)
        {
            numberOne = numberOne / 2;

            Console.WriteLine(numberOne);
        }

        public static int SubtractFive(int newNumber, out int timesSubtracted, int times = 1)
        {
            timesSubtracted = 0;
            Console.WriteLine("Enter a number and receive its value minus 5: ");
            newNumber = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < times; i++)
            {
                timesSubtracted++;
                newNumber = newNumber - 5;
            }

            return newNumber;

        }
    }
}
