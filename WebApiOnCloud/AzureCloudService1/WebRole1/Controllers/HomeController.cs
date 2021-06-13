using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRole1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string input)
        {
            ViewBag.Title = "Home Page";
            if (input.Equals("a"))
            {
                return View("check");
            }
            else
            {
                return View("Invalid");           
            }          
        }
    }
}
