using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Content()
        {
            return Content("Content page");
        }

         public IActionResult Html()
        {
            return Content("<html><body>Html page</body></html>","text/html");
        }

        public IActionResult Json()
        {
            return Json(new
            {
                name = "This is Yashwanth Reddy",
                age = "24"
            });

        }
        public IActionResult Joke()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View("/Views/My/index1.cshtml");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
