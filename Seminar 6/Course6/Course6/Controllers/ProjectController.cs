using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course6.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult DoAnAction()
        {
            return Content("Hello World!");
        }

        public ActionResult Search(string alpha)
        {
            string receivedParameter = Server.HtmlEncode(alpha);
            return Content("Search method param = " + receivedParameter);
        }

        public ActionResult HelloUser(string name)
        {
            string receivedParameter = Server.HtmlEncode(name);
            return Content("Hello " + receivedParameter);
        }
    }
}