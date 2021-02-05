using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            n.Amount = 8.8m;
            Console.WriteLine(n.Amount);
            Console.ReadLine();
        }
    }
}
