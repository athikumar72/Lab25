using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab25.Models;

namespace Lab25.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult dataInput()

        {
            return View();
        }

       [HttpPost]
       public ActionResult dataInput(dataValidation validation)

        {
            if (ModelState.IsValid)
            {
                ViewBag.greetings = "Hi I am a hard worker";
                return View("display", validation);
            }
            else
            {
                return View();

            }

           
        }
      

        public ActionResult  display(dataValidation validation)

        {
            ViewBag.Message = "Your application description page.";
            return View(validation);
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
    }
}