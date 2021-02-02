using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int a;
            int b;
            m.Divide(num1);
            m.Divide(out a, out b);
            Maths.Print();

            Console.WriteLine("The first number is " + a);
            Console.WriteLine("The second number is " + b);
            Console.WriteLine("The static number is " + Maths.Print());

            Console.ReadLine();
        }
    }
}
