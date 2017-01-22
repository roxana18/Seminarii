using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("authorize")]
        [Authorize(Roles ="Admin")]
        public ActionResult ThisMethodNeedsAuthorization()
        {
            return Content("Hello from ThisMethodNeedsAuthorization action");
        }

        [HttpGet]
        public ActionResult VerbsTest()
        {
            return Content("Hello");
        }
       
       [NonAction]
        public ActionResult Calc()
        {
            return Content(" Calc Action");
        }
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("about")]
        public ActionResult SomeMethodName()
        {
            return View("SomeMethodName");
        }
    }
}