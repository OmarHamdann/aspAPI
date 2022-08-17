using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace webAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //my api

            config.Routes.MapHttpRoute(
               name: "myRoute",
               routeTemplate: "api/{controller}/{action}/{year}/{month}/{day}",
               defaults: new {
                   mounth = RouteParameter.Optional,
                   day = RouteParameter.Optional

               }
           );
        }
    }
}
