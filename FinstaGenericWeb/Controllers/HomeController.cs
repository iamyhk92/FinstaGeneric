using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace FinstaGenericWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DashBoard()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
    }
}
