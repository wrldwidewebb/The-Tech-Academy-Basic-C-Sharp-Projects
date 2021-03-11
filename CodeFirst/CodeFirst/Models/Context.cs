using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        base.OnModelCreating(modelBuilder);
    }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}