using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            string X = Console.ReadLine();
            int j = Convert.ToInt32(X);
            Console.WriteLine (50 * j);
            Console.ReadLine();

            Console.WriteLine("Enter Number");
            string Y = Console.ReadLine();
            int k = Convert.ToInt32(Y);
            Console.WriteLine(25 + k);
            Console.ReadLine();

            Console.WriteLine("Enter Number");
            string Z = Console.ReadLine();
            double l = Convert.ToDouble(Z);
            Console.WriteLine(l / 12.5);
            Console.ReadLine();

            Console.WriteLine("Enter Number");
            double B = Convert.ToDouble(Console.ReadLine());
            if (B > 50) Console.WriteLine(true); 
            Console.ReadLine();
            
            Console.WriteLine("Enter Number");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(C % 7);
            Console.ReadLine();

        }
    }
}
