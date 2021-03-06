using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CalculateQuote(int Id)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = db.Insurees.Find(Id);
                var dateOfBirth = insuree.DateOfBirth;
                var carYear = insuree.CarYear;
                var carModel = insuree.CarModel;
                var carMake = insuree.CarMake;
                var speedingTickets = insuree.SpeedingTickets;
                var dui = insuree.DUI;
                var coverageType = insuree.CoverageType;

                var quote = 50.0M;

                if (dateOfBirth.Year >= 2003)
                {
                    quote = quote + 100.00M;
                }
                else if (dateOfBirth.Year <= 2001 && dateOfBirth.Year >= 1996)
                {
                    quote = quote + 50.0M;
                }
                else if (dateOfBirth.Year < 1996)
                {
                    quote = quote + 25.0M;
                }

                if (carYear < 2000)
                {
                    quote = quote + 25.0M;
                }
                else if (carYear > 2015)
                {
                    quote = quote + 25.0M;
                }

                if (carMake == "Porshe")
                {
                    quote = quote + 25.0M;
                }

                if (carMake == "Porshe" && carModel == "911 Carrera")
                {
                    quote = quote + 25.0M;
                }

                quote = quote + (speedingTickets * 10.0M);

                if (dui == true)
                {
                    quote = quote + (quote / 4.0M);
                }

                if (coverageType == true)
                {
                    quote = quote + (quote / 2.0M);
                }
                insuree.Quote = quote;
                db.SaveChanges();

            }
            return View("Index");
        }
    }
}