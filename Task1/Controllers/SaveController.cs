using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Task1.Controllers
{
    public class SaveController : Controller
    {
        // GET: Save
        public ActionResult Index(string xml , string filename)
        {
            Console.WriteLine(xml, filename);
            return View();
        }

        // GET: Save/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Save/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Save/Create
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

        // GET: Save/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Save/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Save/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Save/Delete/5
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
