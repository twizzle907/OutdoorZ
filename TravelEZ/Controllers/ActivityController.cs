using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelEZ.DAL;
using TravelEZ.Models;
using PagedList;

namespace TravelEZ.Controllers
{
    public class ActivityController : Controller
    {
        private AppContext db = new AppContext();

        // GET: Activity
        [HttpGet]
        public ActionResult Index(string sortOrder, string currentFilter, string name, string location, string minLevelString, string ResultString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.LevelSortParm = String.IsNullOrEmpty(sortOrder) ? "level_desc" : "ActivityLevel";

            var acts = new[] {
                new SelectListItem{Value = "1", Text = "1"},
                new SelectListItem{Value = "2", Text = "2"},
                new SelectListItem{Value = "3", Text = "3"},
                new SelectListItem{Value = "4", Text = "4"},
                new SelectListItem{Value = "5", Text = "5"},
            };

            ViewBag.Acts = acts;

            var activities = from a in db.Activities select a;
            if (name != null)
            {
                page = 1;
            }
            else
            {
                name = currentFilter;
            }

            ViewBag.CurrentFilter = name;

            if (!String.IsNullOrEmpty(name))
            {
                activities = activities.Where(s => s.Name.ToLower().Contains(name.ToLower()));
            }

            if (!String.IsNullOrEmpty(location))
            {
                activities = activities.Where(s => s.Location.ToLower().Contains(location.ToLower()));
            }

            if (!String.IsNullOrEmpty(minLevelString))
            {
                int minLevel = 0;
                bool success = int.TryParse(minLevelString, out minLevel);
                if (success && minLevel > 0)
                {
                    activities = activities.Where(s => s.ActivityLevel == minLevel);
                }
            }

            switch (sortOrder)
            {
                case "name_desc":
                    activities = activities.OrderByDescending(s => s.Name);
                    break;
                case "ActivityLevel":
                    activities = activities.OrderBy(s => s.ActivityLevel);
                    break;
                case "level_desc":
                    activities = activities.OrderByDescending(s => s.ActivityLevel);
                    break;
                default:
                    activities = activities.OrderBy(s => s.Name);
                    break;
            }

            var pages = new[] {
                new SelectListItem{Value = "3", Text = "3"},
                new SelectListItem{Value = "5", Text = "5"},
                new SelectListItem{Value = "7", Text = "7"},
                new SelectListItem{Value = "10", Text = "10"},
            };
            ViewBag.Pages = pages;

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(ResultString))
            {
                int min = 0;
                bool success = int.TryParse(ResultString, out min); 
                if ((success) && min > 0)
                {
                    pageSize = int.Parse(ResultString);
                }
            }
            else
            {
                pageSize = 3;
            }
            return View(activities.ToPagedList(pageNumber, pageSize));
        }

        // GET: Activity/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                return HttpNotFound();
            }
            return View(activity);
        }

        // GET: Activity/Create
        [Authorize(Roles = "canEdit")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Activity/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canEdit")]
        public ActionResult Create([Bind(Include = "ID,Name,Location,ActivityLevel")] Activity activity)
        {
            if (ModelState.IsValid)
            {
                db.Activities.Add(activity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activity);
        }

        // GET: Activity/Edit/5
        [Authorize(Roles = "canEdit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                return HttpNotFound();
            }
            return View(activity);
        }

        // POST: Activity/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canEdit")]
        public ActionResult Edit([Bind(Include = "ID,Name,Location,ActivityLevel")] Activity activity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activity);
        }

        // GET: Activity/Delete/5
        [Authorize(Roles = "canEdit")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                return HttpNotFound();
            }
            return View(activity);
        }

        // POST: Activity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canEdit")]
        public ActionResult DeleteConfirmed(int id)
        {
            Activity activity = db.Activities.Find(id);
            db.Activities.Remove(activity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public JsonResult getActivity()
        {
            Activity activity = new Activity();
            return Json(activity.getActivityList(), JsonRequestBehavior.AllowGet);
        }
    }
}
