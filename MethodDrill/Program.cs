using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne math = new MethodOne();
            Console.WriteLine("Please enter a number into the math console ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number plus 10 = " + math.mathOperation1(input)); 
            Console.WriteLine("Your number entered minus 10 = " + math.mathOperation2(input)); 
            Console.WriteLine("Your number entered times 10 = " + math.mathOperation3(input));
            Console.ReadLine();
        }
    }
}
