using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Course8.Models;
namespace Course8.Controllers
{
    public class EvaluationController : Controller
    {

        static List<ProjectEvaluation> evaluations = new List<ProjectEvaluation>
        {
            new ProjectEvaluation() { Id= 1, Name= "Roxana", City = "Marasesti", Country  = "Romania", Rating = 10},
            new ProjectEvaluation() { Id = 2, Name = "Elena", City = "Cluj-Napoca", Country  = "Romania", Rating = 9.0},
            new ProjectEvaluation() { Id = 3, Name = "Ioana", City = "<script>alert('xss');</script>", Country  = "Romania", Rating = 8.9}
        };
        // GET: Evaluation
        public ActionResult Index()
        {
            return View(evaluations);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            var evaluation = evaluations.Single(e => e.Id == id);
            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var evaluation = evaluations.Single(e => e.Id == id);
            if (TryUpdateModel(evaluation))
            { return RedirectToAction("Index"); }
            return View(evaluation);
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
