using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayandListDrill
{
    class Program
    {
        static void Main()
        {
            string[] array1 = new string[] { "Hey", "How are you", "I am fine" };
            Console.ReadLine();
            Console.WriteLine("Please select index 0, 1 or 2 to display corresponding text");
            string index = Console.ReadLine();
            int m = Convert.ToInt32(index);
            bool indexTrueOrFalse = m == 0 && m == 1 && m == 2;

            do
            {
                switch (m)
                {
                    case 3:
                        Console.WriteLine("Wrong index input. Try 0, 1 or 2.");
                        m = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong index input, please try 0, 1, or 2.");
                        m = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 0:
                        indexTrueOrFalse = true;
                        break;
                    case 1:
                        indexTrueOrFalse = true;
                        break;
                    case 2:
                        indexTrueOrFalse = true;
                        break;
                    default:
                        Console.WriteLine("Try another index.");
                        m = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!indexTrueOrFalse);

            Console.WriteLine(array1[m]);
            Console.ReadLine();

            int[] array2 = new int[] { 2, 22, 222 };

            Console.WriteLine("Please select index 0, 1 or 2 to display corresponding integer");
            string index1 = Console.ReadLine();
            int n = Convert.ToInt32(index1);
            bool indexTrueOrFalse1 = n == 0 && n == 1 && n == 2;

            do
            {
                switch (n)
                {
                    case 3:
                        Console.WriteLine("Wrong number input! Use 0, 1 or 2");
                        n = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong number input! Try again using 0, 1, or 2");
                        n = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 0:
                        indexTrueOrFalse1 = true;
                        break;
                    case 1:
                        indexTrueOrFalse1 = true;
                        break;
                    case 2:
                        indexTrueOrFalse1 = true;
                        break;
                    default:
                        Console.WriteLine("Try another number");
                        n = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!indexTrueOrFalse1);

            Console.WriteLine(array2[n]);
            Console.ReadLine();

            List<string> myList = new List<string>();
            myList.Add("What is your favorite food?");
            myList.Add("What is your favorite number?");
            myList.Add("Where were you born?");

            Console.WriteLine("Please select index 0, 1 or 2 to display corresponding content");
            string index2 = Console.ReadLine();
            int p = Convert.ToInt32(index2);
            bool indexTrueOrFalse2 = n == 0 && n == 1 && n == 2;

            do
            {
                switch (p)
                {
                    case 3:
                        Console.WriteLine("Wrong index input! Try 0, 1 or 2.");
                        p = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong index input! Try again.");
                        p = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 0:
                        indexTrueOrFalse2 = true;
                        break;
                    case 1:
                        indexTrueOrFalse2 = true;
                        break;
                    case 2:
                        indexTrueOrFalse2 = true;
                        break;
                    default:
                        Console.WriteLine("Try another index.");
                        p = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!indexTrueOrFalse2);
            Console.WriteLine(myList[p]);
            Console.ReadLine();
        }
    }
}
