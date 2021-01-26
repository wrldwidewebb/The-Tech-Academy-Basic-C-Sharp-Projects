using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileandDoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many dogs does Bob own?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberOfDogs = number == 3;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("He has more than 1 dog, please try again.");
                        Console.WriteLine("Guess the number of dogs");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("He has less than 10 dogs, please try again.");
                        Console.WriteLine("Guess the number of dogs");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You are correct, Bob has 3 dogs.");
                        numberOfDogs = true;
                        break;
                    default:
                        Console.WriteLine("Try another number");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!numberOfDogs);

            Console.Read();

            Console.WriteLine("How many cats does John have?");
            int numbers = Convert.ToInt32(Console.ReadLine());
            bool numberOfCats = numbers == 4;

            while (!numberOfCats)
            {
                switch (numbers)
                {
                    case 1:
                        Console.WriteLine("He has more than 1 cat, please try again");
                        Console.WriteLine("Guess a number");
                        numbers = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("He has less than 5 cats, please try again.");
                        Console.WriteLine("Guess a number");
                        numbers = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You are correct, John has 4 cats.");
                        numberOfCats = true;
                        break;
                    default:
                        Console.WriteLine("Try again");
                        Console.WriteLine("Guess a number");
                        numbers = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}


