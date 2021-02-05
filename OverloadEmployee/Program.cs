using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee n = new Employee();
            n.ID = 001;
            Employee m = new Employee();
            m.ID = 002;

            bool status = n.ID == m.ID;

            Console.WriteLine("Does employee 1 have the same ID as employee 2? " + status);
            Console.ReadLine();
        }
    }
}
