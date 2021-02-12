using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constvarchain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            var year = 1979;

            Showrooms showroom1 = new Showrooms(23, "Aries");
            Showrooms showroom2 = new Showrooms("Apollo");

            Console.WriteLine("Welcome to " + casinoName + " built in " + year + ". Our finest showrooms are:  \n" + showroom1.named + " & " + showroom2.named + "\n");

            Console.ReadLine();

        }
    }
}
