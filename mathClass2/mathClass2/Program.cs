using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass2
{
    class MathOperation
    {
        //1. Create a class.  In that class, create a void method that takes two integers as parameters.
        //   Have the method do a math operation on the first integer and display the second integer to the screen.
        

        //2. In the Main() method of the console app, instantiate the class.
        static void Main()
        {
            Math1Display2 number = new Math1Display2();
            //3.  Call the method in the class, passing in two numbers.           
            Math1Display2.Addition(8, 14);
            //4.  Call the method in the class, specifying the parameters by name.
            Math1Display2.Addition(i:5,j:8);
            
            Console.Read();
        }

    }

}
