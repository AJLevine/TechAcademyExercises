﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass3
{
    

    public class IntegerOperation
    {
        //1.Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.
        public int IntOperation(int newInt)
        {
            
            Console.WriteLine("Enter an integer and you will receive an integer 100x its value: ");
            newInt = Convert.ToInt32(Console.ReadLine());
            newInt = newInt * 100;
            return newInt;
            //Console.WriteLine("Your new total is: " + newInt);


        }
        //3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.
        public int IntOperation(double newDecimal)
        {
            Console.WriteLine("Enter a decimal and you will receive an decimal 10x its value: ");
            newDecimal = Convert.ToDouble(Console.ReadLine());
            newDecimal = newDecimal * 10;
            int newerDecimal = Convert.ToInt32(newDecimal);
            return newerDecimal;
            //Console.WriteLine("Your new total is: " + newDecimal);

        }
        //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.

        public int IntOperation(string stringInt)
        {

            Console.WriteLine("Enter a number and you will receive an number 5x its value: ");
            stringInt = Console.ReadLine();
            int num;
            bool succeed = int.TryParse(stringInt, out num);
            if(succeed)
            {
                num = num * 5;               
            }     
            else
            {
                Console.WriteLine(stringInt + " is not a number");
            }

            return num;
            
        }
    }
}
