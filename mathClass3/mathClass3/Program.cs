using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.
            IntegerOperation one = new IntegerOperation();

            one.IntOperation(12);

            
            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            IntegerOperation two = new IntegerOperation();

            two.IntOperation(12.5432);

            //6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.
            IntegerOperation three = new IntegerOperation();

            three.IntOperation(48230);
        }
    }
}
