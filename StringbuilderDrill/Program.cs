using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringbuilderDrill
{
    class Program
    {
        static void Main()
        {
            string firstName = "Ira";
            string middlename = "Gret";
            string lastName = "Jumping";

            Console.WriteLine("His name is " + firstName + " " + middlename + " " + lastName);
            Console.ReadLine();

            firstName = firstName.ToUpper();
            Console.WriteLine(firstName);
            Console.ReadLine();

            lastName = lastName.ToUpper();
            Console.WriteLine(lastName);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Good");
            sb.Append("Better");
            sb.Append("Best");
            sb.Append("I hope you feel BEST");
            sb.Append("Fifty yards to the john");
            sb.Append("By Kenny Makeit and Betty Wont");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
