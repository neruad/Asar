using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsarGlobal.Web.Controllers
{
    public class MarketingController : Controller
    {
        public ActionResult Start()
        {
            ViewBag.Title = "Старт пакет";
            return View();
        }

        public ActionResult Business()
        {
            ViewBag.Title = "Бизнес пакет";
            return View();
        }

        public ActionResult Vip()
        {
            ViewBag.Title = "VIP пакет";
            return View();
        }
    }
}