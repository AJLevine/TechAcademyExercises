﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass4
{
    public class MathOperation
    {
        //     1.   Create a class. In that class, create a method that takes two integers as parameters.
        //          Make one of them optional.Have the method do a math operation and return a integer result.
        

        public int Taketwo (int firstParam, int secondParam = 1)
        {
            firstParam = firstParam * 5;
            
            return firstParam;


        }

        
        //     4. Call the method in the class, passing in the one or two numbers entered.
        
    }
}
