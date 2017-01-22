using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Course6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                        name: "ActionResulReturnFile",
                        url: "ActionResult/ReturnFile",
                        defaults: new { controller = "ActionResult", action = "ReturnFile" }
                            );

            routes.MapRoute(
             name: "ActionResulRedirectToRoute",
             url: "ActionResult/RedirectToRoute",
             defaults: new { controller = "ActionResult", action = "RedirectToRoute" }
                 );

            routes.MapRoute(
              name: "ActionResulRedirectToActionInHomeController",
              url: "ActionResult/RedirectToActionInHomeController",
              defaults: new { controller = "ActionResult", action = "RedirectToActionInHomeController" }
                  );

            routes.MapRoute(
              name: "ActionResulRedirectPermanent",
              url: "ActionResult/RedirectPermanent",
              defaults: new { controller = "ActionResult", action = "RedirectPermanent" }
                  );

            routes.MapRoute(
             name: "ActionResulRedirectToActionInTheSameController",
             url: "ActionResult/RedirectToActionInTheSameController",
             defaults: new { controller = "ActionResult", action = "RedirectToActionInTheSameController" }
                 );

            routes.MapRoute(
                name: "ProjectHelloUser",
                url: "Project/HelloUser/{name}",
                defaults: new {  controller = "Project", action = "hellouser", name = UrlParameter.Optional}
                );
            routes.MapRoute(
               name: "ProjectSearch",
               url: "Project/{alpha}",
               defaults: new { controller = "Project", action = "search", alpha = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
          routes.MapRoute(
                name: "ProjectDoAnAction",
                url: "Project/doanaction",
                defaults: new { controller = "Project", action = "doanaction",  name = UrlParameter.Optional});
         
        }
    }
}
