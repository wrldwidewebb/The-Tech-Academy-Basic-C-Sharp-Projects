using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee n = new Employee();
            n.FirstName = "Sample";
            n.LastName = "Student";
            n.SayName();
            IQuittable m = new Employee();
            m.Quit();
            Console.ReadLine();
        }
    }
}
