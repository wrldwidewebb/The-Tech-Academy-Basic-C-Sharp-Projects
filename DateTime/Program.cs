using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Time = new DateTime();
            Time = DateTime.Now;
            Console.WriteLine("Hello. The current date and time is {0}", Time);
            Console.WriteLine("Enter a number to see what time it will be in that number of hours");
            double Hours = Convert.ToDouble(Console.ReadLine());
            Time = Time.AddHours(Hours);
            Console.WriteLine("In {0} hours, it will be", Convert.ToString(Hours));
            Console.WriteLine(Time);

            Console.Read();
        }
    }

    
}
