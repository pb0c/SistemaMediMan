﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SistemaMediMan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Paciente",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Paciente", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Empleado",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Empleado", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
