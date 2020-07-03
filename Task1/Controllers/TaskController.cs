using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Task1.DAL;
using Task1.Enums;
using Task1.Models;

namespace Task1.Controllers
{
    public class TaskController : Controller
    {
        private TaskContext db = new TaskContext();

        // GET: Task
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(db.Tasks.ToList());
            }

            return View(db.Stories.Where(t => t.id == id).FirstOrDefault().Tasks.ToList());

        }


        // GET: Tasks/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Stories.Where(s => s.id == task.StoryId).FirstOrDefault().Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = task.StoryId });
            }

            return View(task);
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                List<File> Files = (List<File>)task.Files;

                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = task.StoryId });
            }
            return View(task);
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task task = db.Tasks.Find(id);
            var storyId = task.StoryId;
            db.Tasks.Remove(task);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = task.StoryId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
