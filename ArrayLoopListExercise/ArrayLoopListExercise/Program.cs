using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoopListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[3];
            Console.WriteLine("You will be a few of your all-time favorite words. Lets begin.");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Type " + (stringArray.Length - i) + " more of your favorite words: ");
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("You typed: ");

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine("Press any key to continue to the next step: ");
            Console.ReadLine();

            //for (; ; )
            //{ }

            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("This is a loop with a \"less than\" comparison");
            }
            for (int i = 0; i <= 10; i++)

            {
                Console.WriteLine("This is a loop with a \"less than or equal to\" comparison");
            }
            Console.WriteLine("Press any key to continue to the next step: ");
            Console.ReadLine();

            string[] stringArray1 = new string[] { "dog", "cat", "horse", "sheep", "cow", "llama", "donkey", "goat" };

            Console.WriteLine("Search for a four-legged animal (use lower case letters): ");
            string animalInput = Console.ReadLine();
            for (int i = 0; i < stringArray1.Length; i++)
            {
                if (animalInput==stringArray1[i])
                {
                    Console.WriteLine("Yes, there is a " + animalInput + " in position " + i);
                    break;
                }
                else if (animalInput!=stringArray1[i])
                {
                    Console.WriteLine("There is not a " + animalInput + " in position " + i);
                    Console.WriteLine("Searching again.");
                }
                Console.Read();
            }

            Console.WriteLine("Press any key to continue to the next step: ");
            Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add("Seal");
            stringList.Add("Bird");
            stringList.Add("Iguana");
            stringList.Add("Giraffe");
            stringList.Add("Zebra");
            stringList.Add("Elephant");
            stringList.Add("Jackal");
            stringList.Add("Lion");
            stringList.Add("Bear");
            stringList.Add("Tiger");
            stringList.Add("Iguana");

            bool isPresent = false;

            Console.WriteLine("Enter the name of an animal you would find at the zoo: ");
            string userAnimal = Console.ReadLine();
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i] == userAnimal)
                {
                    Console.WriteLine("The " + userAnimal + " is located at index " + i);
                }
                else if (i == stringList.Count && isPresent == false)
                {
                    Console.WriteLine("No, there is not a " + userAnimal + " in this list");
                    Console.Read();
                }
            }

            Console.WriteLine("Press any key to continue to the next step: ");
            Console.ReadLine();

            List<string> stringList1 = new List<string>();
            stringList1.Add("Missouri");
            stringList1.Add("Georgia");
            stringList1.Add("Michigan");
            stringList1.Add("Virginia");
            stringList1.Add("Florida");
            stringList1.Add("Ohio");
            stringList1.Add("Wisconsin");
            stringList1.Add("Florida");
            stringList1.Add("Georgia");
            stringList1.Add("Michigan");
            stringList1.Add("Minnesota");

            var q = from x in stringList1
                    group x by x into g
                    let count = g.Count()
                    //orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                if (x.Count > 1)
                {
                    Console.WriteLine(x.Value + " (appears twice in this list)");
                }
                else
                {
                    Console.WriteLine(x.Value);
                }

            }
            Console.ReadLine();
        }
    }
}
