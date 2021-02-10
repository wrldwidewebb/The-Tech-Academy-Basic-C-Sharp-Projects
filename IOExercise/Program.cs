using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IOExercise
{
    class Program
    {
        static void Main()
        { 
        Console.WriteLine("Please enter a whole number");
            string Num = Console.ReadLine();
            string filePath = @"C:\Users\Steve\Desktop\Folder1\Number\log.txt";
            string Text;
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(Num);
            }
            using (StreamReader file = new StreamReader(filePath, true))
{
            Text = file.ReadToEnd().ToString();
}

            Console.WriteLine("Number logged to {0}", filePath);
            Console.WriteLine("File contents:");
            Console.WriteLine(Text);

            Console.Read();
        }
    }
}
