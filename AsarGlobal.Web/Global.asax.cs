using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using AsarGlobal.Web.App_Start;
using NLog;

namespace AsarGlobal.Web
{
    public class Global : System.Web.HttpApplication
    {
        private static ILogger _logger = LogManager.GetCurrentClassLogger();

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            _logger.Error("URLs: {0} -> {1}", HttpContext.Current.Request.UrlReferrer, HttpContext.Current.Request.Url);
            _logger.Error("[{0}] {1}", ex.GetType(), ex);

            Response.Redirect("~/error.html");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}