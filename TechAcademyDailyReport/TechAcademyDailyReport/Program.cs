using System;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            string course;
            int pageNum;
            bool isHelpNeeded;
            string posFeedback;
            string otherFeedback;
            int hoursStudy;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.Write("What course are you on?");
            course = Console.ReadLine();
            Console.Write("What page number are you on?");
            pageNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you need help with anything? Please answer “true” or “false”.");
            isHelpNeeded = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Were there any positive experiences you'd like to share? Please give specifics.");
            posFeedback = Console.ReadLine();
            Console.Write("Is there any other feedback you'd like to provide? Please be specific.");
            otherFeedback = Console.ReadLine();
            Console.Write("How many hours did you study today?");
            hoursStudy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();


        }
    }
}
