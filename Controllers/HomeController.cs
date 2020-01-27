using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace md753815MIS4200spring.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS4200 description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email: md753815@ohio.edu";

            return View();
        }
    }
}