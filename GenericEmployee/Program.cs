using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> n = new Employee<string>();
            n.things = new List<string>()
            {
                "Red",
                "Blue",
                "Yellow"
            };

            Employee<int> m = new Employee<int>();
            m.things = new List<int>()
            {
                1,
                2,
                3
            };
            n.things.ForEach(x => Console.WriteLine(x));
            m.things.ForEach(z => Console.WriteLine(z));
            Console.ReadLine();

        }
    }
}
