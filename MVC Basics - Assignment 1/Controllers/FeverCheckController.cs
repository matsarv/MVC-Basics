using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics___Assignment_1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_Basics___Assignment_1.Controllers
{
    public class FeverCheckController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int temperature,string celciusfahrenheit)
        {
            ViewBag.Index = FeverCheck.Fever(temperature, celciusfahrenheit);
            return View();
        }
    }
}
