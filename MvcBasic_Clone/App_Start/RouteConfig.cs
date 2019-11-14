using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBasic_Clone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MacRoute",
                url: "Mac",
                defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "IpadRoute",
                url: "Ipad",
                defaults: new { controller = "Ipad", action = "IpadPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "IphoneRoute",
                url: "Iphone",
                defaults: new { controller = "Iphone", action = "IphonePage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "WatchRoute",
                url: "Watch",
                defaults: new { controller = "Watch", action = "WatchPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "FriendsRoute",
                url: "Friends",
                defaults: new { controller = "Friends", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "EmployeesRoute",
                url: "Employees",
                defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
