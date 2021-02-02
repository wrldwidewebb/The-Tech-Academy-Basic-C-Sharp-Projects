using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();

            Console.WriteLine("Choose number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select enter to use the default number");
            string num2 = Console.ReadLine();
            Console.WriteLine("Adding the first number to the second number");
            if (num2 == "")
            {
                Console.WriteLine("The answer is " + m.Addition(num1));
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Console.WriteLine("The answer is " + m.Addition(num1, num3));
            }
            Console.ReadLine();

        }
    }
}
