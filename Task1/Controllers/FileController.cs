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
    public class FileController : Controller
    {
        private TaskContext db = new TaskContext();
        // GET: Files
        public ActionResult Index(int storyId, int taskId)
        {
            return View(db.Tasks.Where(f => f.id == taskId).FirstOrDefault().Files.ToList());
        }


        // GET: Files/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // GET: Files/Create
        public ActionResult Create(int storyId, int taskId)
        {

            return View();
        }

        // POST: Files/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FileType,Name,Description,TaskId")] File file)
        {

            if (ModelState.IsValid)
            {
                //db.Tasks.Where(f => f.id == taskID).FirstOrDefault().Files.Add(new Models.File{Name= file.Name, Description = file.Description, FileType = file.FileType});
                db.Tasks.Where(t => t.id == file.TaskId).FirstOrDefault().Files.Add(file);
                db.SaveChanges();
                return RedirectToAction("Index", new { storyId=Request.QueryString["storyId"], taskId = file.TaskId});
            }

            return View(file);
        }

        // GET: Files/Edit/1/1
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // POST: Files/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, FileType,Name,Description,TaskId")] File file)
        {
            if (ModelState.IsValid)
            {
                db.Entry(file).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { storyId=Request.QueryString["storyId"], taskId = file.TaskId});
            }
            return View(file);
        }

        // GET: Files/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // POST: Files/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int taskId)
        {
            File file = db.Files.Find(id);
            db.Files.Remove(file);
            db.SaveChanges();
            return RedirectToAction("Index", new { storyId = Request.QueryString["storyId"], taskId });
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
