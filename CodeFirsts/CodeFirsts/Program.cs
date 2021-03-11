
using CodeFirsts.Models;

namespace CodeFirsts
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var databaseCreated = ctx.Database.CreateIfNotExists();


                var stud = new Student { FirstName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}




