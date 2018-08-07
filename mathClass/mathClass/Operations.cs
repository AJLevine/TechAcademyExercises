using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass
{
    class Operations
    {
        //1. Create a class. In that class, create three methods,
        //   each of which will take one integer parameter in
        //   and return an integer.The methods should do some math
        //   operation on the received parameter.
        //   Put this class in a separate.cs file in the application.
        public static int Addition(int i)
        {
            return i + i;
        }

        public static int Multiply(int j)
        {
            return j * j;
        }

        public static int addEight(int k)
        {
            return k + 8;
        }


        //2. In the Main() program, ask the user what number they
        //   want to do the math operations on.
        static void Main()
        {
            Console.WriteLine("What number would you like to do some math on? Enter an integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            //3. Call each method in turn, passing the user input to the method.
            //   Display the returned integer to the screen.
            int Total = Addition(number1);
            int Product = Multiply(number1);
            int PlusEight = addEight(number1);

            Console.WriteLine(number1 + " plus " + number1 + " equals " + Total);
            Console.WriteLine(number1 + " multiplied by " + number1 + " equals " + Product);
            Console.WriteLine(number1 + " plus eight equals " + PlusEight);

            Console.Read();
        }
       
    }
 
}
