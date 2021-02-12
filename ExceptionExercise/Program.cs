using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise 
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool ageNow = false;
            while (!ageNow)
                {
                    Console.Write("What is your current age?");
                    try
                    {
                        ageNow = int.TryParse(Console.ReadLine(), out int age);
                        if (ageNow == false)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            BirthCalcs convertAge = new BirthCalcs();
                            int birthYear = convertAge.Year(age);
                            Console.WriteLine($"\nYou were born in {birthYear} or {birthYear - 1}, depending on when your actual Birthdate was!");
                        
                catch (NegativeException)
                {
                    Console.WriteLine("Please enter a positive whole number.");
                }
                catch (ZeroException)
                {
                    Console.WriteLine("An error occurred. Please enter a whole number.");
                }
            }
            Console.ReadLine();
        }
    }
}
