using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AsarGlobal.Web.App_Code.Helpers
{
    public static class MenuHelper
    {
        public static string IsSelected(this ViewContext viewContext, string controllers = "", string actions = "", string cssClass = "active")
        {
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction)
                viewContext = viewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString();
            string currentController = routeValues["controller"].ToString();

            if (String.IsNullOrEmpty(actions))
                actions = currentAction;

            if (String.IsNullOrEmpty(controllers))
                controllers = currentController;

            string[] acceptedActions = actions.Trim().Split(',').Distinct().ToArray();
            string[] acceptedControllers = controllers.Trim().Split(',').Distinct().ToArray();

            return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ?
                cssClass : String.Empty;
        }
    }
}