using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass4
{
    class Program
    {
        public static void Main(string[] args)
        {

            //     2. In the Main() method of the console app, instantiate the class.
            mathOperation firstAttempt = new mathOperation();

            //     3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
            Console.WriteLine("Input two numbers, one at a time.  The second number is optional: ");
            int firstParam = Convert.ToInt32(Console.ReadLine());
            int secondParam = Convert.ToInt32(Console.ReadLine());

            mathOperation.Taketwo(firstParam, secondParam);

            Console.WriteLine(firstParam);

            Console.ReadKey();
         }
    }

}
        

