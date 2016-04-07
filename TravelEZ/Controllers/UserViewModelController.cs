using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelEZ.Models;

namespace TravelEZ.Controllers
{
    [Authorize (Roles="Admin")]
  
    public class UserViewModelController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserViewModel
        public ActionResult Index()
        {
            var allusers = db.Users.ToList();
            var userVM = allusers.Select(user => new UserViewModel { Id = user.Id, Email = user.Email }).ToList(); 
            var model = new ListUserViewModel { Users = userVM };

            return View(model);
           
        }

        // GET: UserViewModel/Details/5
        //[Authorize]
        public ActionResult Details(string id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserViewModel userViewModel = db.UserViewModels.Find(id);
            if (userViewModel == null)
            {
                return HttpNotFound();
            }
            return View(userViewModel);
        }

        // GET: UserViewModel/Create
        [Authorize(Roles = "Admin")]//changed "canEdit"
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserViewModel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")] //changed "canEdit"
        public ActionResult Create([Bind(Include = "Id,Username")] UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                db.UserViewModels.Add(userViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userViewModel);
        }

        // GET: UserViewModel/Edit/5
        [Authorize(Roles = "Admin")]//changed "canEdit"
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserViewModel userViewModel = db.UserViewModels.Find(id);
            if (userViewModel == null)
            {
                return HttpNotFound();
            }
            return View(userViewModel);
        }

        // POST: UserViewModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]//changed "canEdit"
        public ActionResult Edit([Bind(Include = "Id,Username")] UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userViewModel);
        }

        // GET: UserViewModel/Delete/5
        [Authorize(Roles = "Admin")]//changed "canEdit"
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserViewModel userViewModel = db.UserViewModels.Find(id);
            if (userViewModel == null)
            {
                return HttpNotFound();
            }
            return View(userViewModel);
        }

        // POST: UserViewModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]//changed "canEdit"
        public ActionResult DeleteConfirmed(string id)
        {
            UserViewModel userViewModel = db.UserViewModels.Find(id);
            db.UserViewModels.Remove(userViewModel);
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
