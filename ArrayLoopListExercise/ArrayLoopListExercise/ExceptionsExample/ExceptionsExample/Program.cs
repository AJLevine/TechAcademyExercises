using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExample
{
    class Program
    {
        static void Main(string [] args)
        {
            try
            {
                int[] dividendArray = new int[6];
                dividendArray[0] = 18;
                dividendArray[1] = 27;
                dividendArray[2] = 36;
                dividendArray[3] = 45;
                dividendArray[4] = 54;
                dividendArray[5] = 63;
                int[] quotientArray = new int[6];
                Console.WriteLine("Here is a list of numbers: ");
                for (int i = 0; i < dividendArray.Length; i++)
                {
                    Console.WriteLine(dividendArray[i]);
                }
                Console.WriteLine("Pick a number to divide these numbers by: ");
                int divisorOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the numbers...");
                for (int i = 0; i<dividendArray.Length; i++)
                {
                    quotientArray[i] = dividendArray[i] / divisorOne;
                }
                Console.WriteLine("The quotients are: ");
                for (int i = 0; i < quotientArray.Length; i++)
                {
                    Console.WriteLine(quotientArray[i]);
                }
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number: ");
                Console.Read();
                return;
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero");
                Console.Read();
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                return;
            }
            Console.ReadLine();
        }
    }
}
