using AsarGlobal.Web.Models.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsarGlobal.Web.Controllers
{
    public class BlogsController : Controller
    {

        public ActionResult List()
        {
            ViewBag.Title = "Блог";
            return View();
        }

        public ActionResult Content(string name)
        {
            ViewBag.Title = "Блог";

            var model = new StaticBlogViewModel();
            model.Name = name;
            return View(model);
        }
    }
}