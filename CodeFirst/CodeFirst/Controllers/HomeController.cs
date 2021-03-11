using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;


namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult  Instructor()
        {
            using (var context = new StudentContext())
            {
                List<Instructor> instructors = new List<Instructor>
                {
                    new Instructor
                    {
                    Id = 1,
                    FirstName = "Diane",
                    LastName = "Filut"
                    },

                    new Instructor
                    {
                    Id = 2,
                    FirstName = "Linda",
                    LastName = "Deluga"
                    },

                    new Instructor
                    {
                    Id = 3,
                    FirstName = "Cynthia",
                    LastName = "Rymaster"
                    }
                };
                instructors.ForEach(s => context.Instructors.Add(s));
                context.SaveChanges();

                return View(instructors);
            }



        }

        public ActionResult Student()
        {
            using (var context = new StudentContext())
            {
                List<Student> student = new List<Student>
                {
                    new Student
                    {
                    Id = 1,
                    FirstName = "Brad",
                    LastName = "Jefferson"
                    },

                    new Student
                    {
                    Id = 2,
                    FirstName = "Anton",
                    LastName = "Coleman"
                    },

                    new Student
                    {
                    Id = 3,
                    FirstName = "Brunow",
                    LastName = "Shaw"
                    }
                };
                student.ForEach(s => context.Students.Add(s));
                context.SaveChanges();

                return View(student);
            }

        }
    }
}