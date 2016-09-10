using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace drs_interior_design.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Here is How it Works.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Lets Set up an Appointment.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
