using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.DAL;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext db = new TaskContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Stories.ToList());
        }

        public ActionResult Search(string searchString)
        {

            var stories = db.Stories.Where(s => s.name.Contains(searchString)).ToList();

            var tasks = db.Tasks.Where(t => t.name.Contains(searchString)
            || t.what.Contains(searchString) 
            || t.why.Contains(searchString) 
            || t.how.Contains(searchString)).ToList();

            var files = db.Files.Where(f => f.Name.Contains(searchString)
            || f.Description.Contains(searchString)
            || f.FileType.ToString().Contains(searchString)).ToList();

            Search search = new Search() { stories = stories, tasks = tasks, files = files };
            return View(search);
        }
    }
}
