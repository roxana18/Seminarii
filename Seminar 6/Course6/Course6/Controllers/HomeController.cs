using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HelloWord()
        {
            return Content("HelloWorld");
        }

        public double ListAverage()
        {
            var list = new List<int> { 1, 3, 7, 9, 2, 4, 5, 6, 8, 10 };
            //return list.Average();
            int sum = 0;
            foreach (int x in list)
            {
                sum += x;
            }
            return sum / list.Count();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}