using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* if we need a route with multiple parameters and want to build 
             * our own custom route instead of using the default */
            //Old style
            /*
            * routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action = "ByRealeaseDate" },
           
                //building a constrait
                new { year = @"2015|2016", month = @"\d{2}" }
            );
            */

            //using attribute routing
            //this is a more effecient way than above

            routes.MapMvcAttributeRoutes();
        
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
