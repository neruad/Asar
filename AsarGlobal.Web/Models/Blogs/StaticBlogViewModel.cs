using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsarGlobal.Web.Models.Blogs
{
    public class StaticBlogViewModel : BlogsViewModel
    {
        public string ContentPath { get { return "~/Views/Blogs/Static/"; } }
        public string Name { get; set; }
    }
}