using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //get : /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        //
        //get : /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}