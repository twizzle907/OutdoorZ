using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelEZ.DAL;
using TravelEZ.Models;

namespace TravelEZ.Controllers
{
    public class BannedUserController : Controller
    {
        private AppContext db = new AppContext();

        // GET: BannedUser
        public ActionResult Index()
        {
            return View(db.BannedUsers.ToList());
        }

        // GET: BannedUser/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BannedUser bannedUser = db.BannedUsers.Find(id);
            if (bannedUser == null)
            {
                return HttpNotFound();
            }
            return View(bannedUser);
        }

        // GET: BannedUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BannedUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Email")] BannedUser bannedUser)
        public ActionResult Create([Bind(Include = "Email")] BannedUser bannedUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //if (bannedUser.Email )
                    db.BannedUsers.Add(bannedUser);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log. 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            } 
            return View(bannedUser);
        }

        // GET: BannedUser/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BannedUser bannedUser = db.BannedUsers.Find(id);
            if (bannedUser == null)
            {
                return HttpNotFound();
            }
            return View(bannedUser);
        }

        // POST: BannedUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email")] BannedUser bannedUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bannedUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bannedUser);
        }

        // GET: BannedUser/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BannedUser bannedUser = db.BannedUsers.Find(id);
            if (bannedUser == null)
            {
                return HttpNotFound();
            }
            return View(bannedUser);
        }

        // POST: BannedUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BannedUser bannedUser = db.BannedUsers.Find(id);
            db.BannedUsers.Remove(bannedUser);
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
    }
}
