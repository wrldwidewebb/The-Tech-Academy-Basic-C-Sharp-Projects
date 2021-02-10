using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMastaLambdaBetaTheta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> n = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Smith", ID = 001 },
                new Employee() {FirstName = "Jeff", LastName = "Boblick", ID = 002 },
                new Employee() {FirstName = "Joe", LastName = "Waltersonmangenson", ID = 003 },
                new Employee() {FirstName = "Tomer", LastName = "Langberg", ID = 004 },
                new Employee() {FirstName = "Logan", LastName = "Stanley", ID = 005 },
                new Employee() {FirstName = "Hayden", LastName = "Eggert", ID = 006 },
                new Employee() {FirstName = "Jack", LastName = "Gross", ID = 007 },
                new Employee() {FirstName = "Curt", LastName = "Gross", ID = 008 },
                new Employee() {FirstName = "Carol", LastName = "Gross", ID = 009 },
                new Employee() {FirstName = "Bob", LastName = "Teklits", ID = 010 }
            };

            List<Employee> m = new List<Employee>();

            foreach (Employee employee in n)
            {
                if (employee.FirstName == "Joe")
                {
                    m.Add(employee);

                }
            }

            List<Employee> w = n.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> s = n.Where(x => x.ID > 5).ToList();

            Console.WriteLine(n.Count);
            Console.WriteLine(m.Count);
            Console.WriteLine(w.Count);
            Console.WriteLine(s.Count);

            Console.ReadLine();
        }
    }
}
