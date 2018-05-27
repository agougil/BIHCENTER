using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BIHCENTER
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Admins",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Admins", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Projets",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Projets", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Taches",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Taches", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Membres",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Membres", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
