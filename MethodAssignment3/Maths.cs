using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment3
{
    public class Maths
    {
        public void Divide(int a)
        {
            int result = a / 2;
            Console.WriteLine("Your number divided by 2 equals: " + result);
            return;
        }

        public void Divide(out int x, out int y)
        {
            Console.WriteLine("Pick a number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose another number");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static int Print()
        {
            int d = 100;
            return d;
        }
    }
}
