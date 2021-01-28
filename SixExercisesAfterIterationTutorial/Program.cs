using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixExercisesAfterIterationTutorial
{
    class Program
    {
        static void Main()
        {
            string[] foodItems = { "Bread", "Corn", "Apple", "Banana" };
            Console.WriteLine("Please write your favorite beverage");
            string userBeverage = Console.ReadLine();

            for (int q = 0; q < foodItems.Length; q++)
            {
                Console.WriteLine("Food combo is " + foodItems[q] + " and " + userBeverage);
            }
            Console.ReadLine();

            //for (int j = 0; j - 1 < j++; j++)
            //{
            //    Console.WriteLine("infinite loop?");
            //}
            //Console.ReadLine();

            for (int j = 0; j - 1 < foodItems.Length; j++)
            {
                Console.WriteLine("fixed infinite loop");
            }
            Console.ReadLine();

            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("One of the best food combinations is " + foodItems[k] + " and " + userBeverage);
            }
            Console.ReadLine();

            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine("Please get some " + foodItems[l]);
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Packers", "Bucs", "Bills", "Chiefs" };
            Console.WriteLine("Please select and type one of the following teams: Packers, Bucs, Bills, and Chiefs");
            string name = Console.ReadLine();
            var m = 0;
            bool found = false;
            while (m < names.Count && found != true)
            {


                if (name == names[m])
                {
                    found = true;
                    Console.WriteLine("Your input " + name + " equaled the value " + (string)names[m] + " at index " + (int)m);
                }
                m++;
            }
            if (found == false) Console.WriteLine("Your team is not on the list");
            Console.ReadLine();

            List<string> names1 = new List<string>() { "Packers", "Bucs", "Bills", "Chiefs", "Bills" };
            Console.WriteLine("Please type one of the following football teams: Packers, Bucs, and Bills");
            string name1 = Console.ReadLine();
            var n = 0;
            bool found1 = false;
            while (n < names1.Count)
            {
                if (name1 == names1[n])
                {
                    found1 = true;
                    Console.WriteLine("Your input " + name1 + " equaled the value " + (string)names1[n] + " at index " + (int)n);
                }
                n++;
            }
            if (found1 == false) Console.WriteLine("Your team is not on the list");
            Console.ReadLine();

           


            var distinct = new List<string>();
            var duplicates = new List<string>();


            foreach (var team in names1)
            {
                if (!distinct.Contains(team))
                    distinct.Add(team);
                else
                    duplicates.Add(team);
            }
            foreach (var team in distinct)
                Console.WriteLine("The team called the " + team + " has not already appeared in the list");

            foreach (var team in duplicates)
                Console.WriteLine("The team called the " + team + " has already appeared in the list");
            Console.ReadLine();
        }
    }
}
