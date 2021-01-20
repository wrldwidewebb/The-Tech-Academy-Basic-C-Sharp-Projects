using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousincomecomparisonprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate Using Only Numbers");
            double poneperhour = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many full hours did you work this week?");
            int ponehoursworked = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Person 2");
            Console.Write("Enter Hourly Rate Using Only Numbers");
            double ptwoperhour = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("How many full hours do you work on average?: ");
            double ptwohoursworked = Convert.ToDouble(Console.ReadLine());

            int weeksperyear = 52;
            int person1, person2;
            Console.Write("Annual Salary of Person 1");
            person1 = (int)(poneperhour * ptwohoursworked * weeksperyear);
            Console.WriteLine(person1);

            Console.Write("Annual Salary of Person 2");
            person2 = (int)(ptwoperhour * ptwohoursworked * weeksperyear);
            Console.WriteLine(person2);

            Console.Write("Does Person 1 make more money than Person 2?");
            bool f = person1 > person2;
            Console.WriteLine(f.ToString());
            Console.ReadLine();

        }
    }
}
