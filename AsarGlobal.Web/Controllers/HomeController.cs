using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsarGlobal.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Главная";
            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Title = "Контакты";
            return View();
        }
    }
}