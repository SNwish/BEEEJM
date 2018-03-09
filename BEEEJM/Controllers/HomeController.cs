using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BEEEJM.Controllers
{
    public class HomeController : Controller
    {

        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name = "zenek", int ID = 1)
        {
            ViewBag.Message = name;
            ViewBag.Numtimes = ID;
            return View();
        }
    }
}