using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Task1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Story", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "File",
                url: "{controller}/{action}/{storyId}/{taskId}",
                defaults: new { controller = "File", action = "Index", storyId = UrlParameter.Optional, id = UrlParameter.Optional }
            );
        }
    }
}
