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
            double numberOne;
            MathConstructor example = new MathConstructor();
        
            //2. In the Main() method, instantiate that class.
            Console.WriteLine("Type an integer and receive its value divided by two: ");
            numberOne = Convert.ToInt32(Console.ReadLine());

            example.DivideByTwo(numberOne);
            Console.Read();

            Console.WriteLine("Type another number and receive its value divided by two: ");
            numberOne = Convert.ToDouble(Console.ReadLine());
            example.DivideByTwo(numberOne);
            Console.Read();

            //3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

            //4. Create a method with output parameters.

            //5. Overload a method.

            //6. Declare a class to be static.
        }
    }
}
