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
             

            }
            return View("Index");
        }
    }
}