using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinstaGenericInfrastructure;
using FinstaGenericInfrastructure.Models;

namespace FinstaGeneric_Api.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            Contactmaster _Contactmaster = new Contactmaster();
            _Contactmaster.firstName = "";
            return View();
         
           
        }
    }
}