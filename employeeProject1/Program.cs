using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            employee n = new employee();
            n.FirstName = "Sample";
            n.LastName = "Student";
            n.SayName();
            Console.ReadLine();

        }
    }
}
