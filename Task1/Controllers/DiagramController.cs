using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.DAL;

namespace Task1.Controllers
{
    public class DiagramController : Controller
    {
        // GET: Diagram
        private TaskContext db = new TaskContext();
        public ActionResult Index(int id)
        {
            return View(db.Stories.Find(id));
        }


        // POST: Diagram/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(int id, string diagramXML)
        {
            db.Stories.Find(id).diagram = diagramXML;
            db.SaveChanges();
            return RedirectToAction("Index", "Story");
        }


        // POST: Diagram/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Stories.Find(id).diagram = null;
            db.SaveChanges();
            return RedirectToAction("Index", "Story");
        }
    }
}
