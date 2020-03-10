using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Charts()
        {
            return View();
        }
        public ActionResult Elements()
        {
            return View();
        }
        public ActionResult Panels()
        {
            return View();
        }
        public ActionResult Widgets()
        {
            return View();
        }
    }
}