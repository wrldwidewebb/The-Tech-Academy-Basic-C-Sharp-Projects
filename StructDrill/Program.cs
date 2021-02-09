using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill
{
    class Program
    {
        public struct Number
        {
        public decimal Amount;
    }
        static void Main(string[] args)
        {
            Number price; 
            price.Amount = 12.2m; 

            Console.WriteLine(price.Amount);
            Console.ReadLine();
          
        }
    }
}
