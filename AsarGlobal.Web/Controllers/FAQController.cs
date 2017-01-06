using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsarGlobal.Web.Controllers
{
    public class FAQController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Вопросы - Ответы";
            return View();
        }
    }
}