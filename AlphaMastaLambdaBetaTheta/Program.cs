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

            Console.WriteLine("All Joes on the employee roster found using a foreach loop");
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee employee in Roster)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                    employee.SayName();
                }
            }

            Console.WriteLine("List of all Joes found using a lambda expression");
            List<Employee> newJoeList = Roster.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in newJoeList)
            {
                employee.SayName();
            }

            Console.WriteLine("Employees with ID greater than 5, found using a lambda expression");
            List<Employee> newEmployees = Roster.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in newEmployees)
            {
                employee.SayName();
                employee.ShowID();

            }

           

            Console.ReadLine();
        }
    }
}

