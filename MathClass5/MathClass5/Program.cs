using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass5
{
    class Program
    {
        static void Main()
        {
            int numberOne;
            double numberTwo;
            int timesSubtracted = 0;
            MathConstructor example = new MathConstructor();

            
            //2. In the Main() method, instantiate that class.
            Console.WriteLine("Type an integer and receive its value divided by two: ");
            numberOne = Convert.ToInt32(Console.ReadLine());

            example.DivideByTwo(numberOne);
            Console.Read();

            //3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

            Console.WriteLine("Type another number and receive its value divided by two: ");
            numberTwo = Convert.ToDouble(Console.ReadLine());
            example.DivideByTwo(numberTwo);
            MathConstructor.SubtractFive(3, out timesSubtracted, 1);
            Console.WriteLine("Times subtracted: {0}", timesSubtracted);
            Console.Read();
        }
            
            //4. Create a method with output parameters.
            
    }
}
