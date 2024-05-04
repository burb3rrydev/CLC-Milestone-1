using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLC_Milestone_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SubmitForm(string FirstName, string LastName, string Sex, int Age, string State, string Email, string Username, string Password)
        {
            // Process the form data here

            // just return a success message
            return Content("Form submitted successfully!");
        }

    }
}