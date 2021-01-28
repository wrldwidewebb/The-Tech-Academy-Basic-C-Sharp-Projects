using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExercise
{
    class Program
    {
        static void Main()
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine("Enter a number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int b in integers)
                {
                    int total = (b / userInput);
                    Console.WriteLine("Dividing " + b + " by " + userInput + " is " + total);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only a whole number.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            finally
            {
                Console.WriteLine("The program has successfully executed. End of program.");
                Console.ReadLine();
            }

            //try
            //{
            //    for (int b = 0; b < integers.Count; b++)
            //    {
            //        Console.WriteLine("Enter a number: ");
            //        int userInput = Convert.ToInt32(Console.ReadLine());
            //        int total = userInput / integers[b];
            //        Console.WriteLine("Dividing " + userInput + "by" + integers[b] + "is" + total);
            //    }
            //    Console.ReadLine();
            //}
        }
    }
}
