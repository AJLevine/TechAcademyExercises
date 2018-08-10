using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass3
{
    

    public class IntegerOperation
    {
        //1.Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.
        public void IntOperation(int newInt)
        {
            
            Console.WriteLine("Enter an integer and you will receive an integer 100x its value: ");
            newInt = Convert.ToInt32(Console.ReadLine());
            newInt = newInt * 100;
            Console.WriteLine("Your new total is: " + newInt);


        }
        //3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.
        public void IntOperation(double newDecimal)
        {
            Console.WriteLine("Enter a decimal and you will receive an decimal 10x its value: ");
            newDecimal = Convert.ToInt32(Console.ReadLine());
            newDecimal = newDecimal * 10;
            Console.WriteLine("Your new total is: " + newDecimal);

        }
        //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.

        public void IntOperation()
        {

            Console.WriteLine("Enter a number and you will receive an number 5x its value: ");
            string three = Console.ReadLine();
            int num;
            bool succeed = int.TryParse(three, out num);
            if(succeed)
            {
                num = num * 5;
                Console.WriteLine("Your new number is: " + num);
            }     
            else
            {
                Console.WriteLine(s + " is not a number");
            }

        }
    }
}
