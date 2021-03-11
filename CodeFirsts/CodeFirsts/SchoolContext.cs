using CodeFirsts.Models;
using System.Data.Entity;

namespace CodeFirsts
{
  
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}

