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
using Microsoft.AspNet.Identity;

namespace TravelEZ.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        private AppContext db = new AppContext();

        // GET: UserProfile
        public ActionResult Index()
        {
            return View(db.UserProfiles.ToList());
        }

        // GET: UserProfile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            return View(userProfile);
        }

        // GET: UserProfile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserProfile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,HomeTown,BirthDate")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                userProfile.UserID = User.Identity.GetUserId();
                db.UserProfiles.Add(userProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userProfile);
        }

        // GET: UserProfile/Edit/5
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);

            if (userProfile == null)
            {
                return HttpNotFound();
            }
            else if (User.Identity.GetUserId().Length == 0 || !userProfile.UserID.Equals(User.Identity.GetUserId()))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
            return View(userProfile);
        }

        // POST: UserProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,HomeTown,BirthDate")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                userProfile.UserID = User.Identity.GetUserId();
                db.Entry(userProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userProfile);
        }

        // GET: UserProfile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            else if (User.Identity.GetUserId().Length == 0 || !userProfile.UserID.Equals(User.Identity.GetUserId()))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
            return View(userProfile);
        }

        // POST: UserProfile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserProfile userProfile = db.UserProfiles.Find(id);

            if (User.Identity.GetUserId().Length == 0 || !userProfile.UserID.Equals(User.Identity.GetUserId()))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            db.UserProfiles.Remove(userProfile);
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
