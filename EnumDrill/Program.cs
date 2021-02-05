using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day of the week");
            string day = Console.ReadLine();

            try
            {
                daysOfTheWeek days = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), day);
                Console.WriteLine("Today is {0}", day);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a real weekday");
                Console.ReadLine();
            }



        }
        enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
    }
}
