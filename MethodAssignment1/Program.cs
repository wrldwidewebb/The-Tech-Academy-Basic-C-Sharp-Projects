using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            decimal b = 6.9m;
            string c = "10";
            int total;
            MathMethod m = new MathMethod();
            total = m.Sum(a);
            Console.WriteLine("The sum of " + a + " and " + "22" + " is " + total);
            total = m.Difference(b);
            Console.WriteLine("The difference between " + b + " and " + "10" + " is " + total);
            total = m.Product(c);
            Console.WriteLine("The product of " + c + " and " + "2" + " is " + total);
            Console.ReadLine();
        }
    }
}
