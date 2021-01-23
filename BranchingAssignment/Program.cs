﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a nice day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length.");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int dimentionTotal = packageWidth + packageHeight + packageLength;
                if (dimentionTotal > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express. Have a nice day.");
                }
                else
                {
                    decimal result = dimentionTotal * packageWeight / 100m;
                    Console.WriteLine("Your estimated total for shipping this package is " + "$" + result);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
    }
}
