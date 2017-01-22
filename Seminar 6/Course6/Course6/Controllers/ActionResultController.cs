using System.Net.Mime;
using System.Web.Mvc;

namespace Course6.Controllers
{
    public class ActionResultController : Controller
    {
        public ActionResult ReturnFile()
        {
            return File("~/Content/Site.css", MediaTypeNames.Text.Plain);
        }
        public ActionResult RedirectToRoute()
        {
            return RedirectToRoute(new { controller = "Home", action = "About" });
        }
        public ActionResult RedirectToActionInHomeController()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult RedirectPermanent()
        {
            return RedirectPermanent("http://www.google.com");
        }

        public ActionResult RedirectToActionInTheSameController()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return Content("This message is sent from the Index action!");
        }
    }
}