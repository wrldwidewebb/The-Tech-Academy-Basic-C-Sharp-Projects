using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceUnderwriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int b = Convert.ToInt16(age);
            Console.WriteLine("Have you ever had a DUI? True or False");
            bool trueOrFalse = Console.ReadLine() == "false";
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int speedingTicket = Convert.ToInt16(speedingTickets);
            Console.WriteLine("Qualified?");
            bool qualification = b > 15 && trueOrFalse && speedingTicket <= 3;
            Console.Write(qualification.ToString());
            Console.ReadLine();

        }
    }
}
