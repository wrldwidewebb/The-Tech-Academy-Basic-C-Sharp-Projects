using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProject.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = bool.Parse("true");

            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("The course you're on is: " + courseName);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageINput = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageINput);
            Console.WriteLine("Your page number is: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false".);
            string needHelp = Console.ReadLine();
            bool helpresultsfeaturingbooleanvariables = bool.Parse(needHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("The thoughts you've shared are as follows: " + positiveExperiences);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("The alternate feedback you mentioned was: " + otherFeedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            double hhoouurrSsttuuddiieedd = Convert.ToDouble(hoursStudied);
            Console.WriteLine("Hours studied ended up being: " + hhoouurrSsttuuddiieedd);
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
