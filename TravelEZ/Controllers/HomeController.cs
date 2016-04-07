using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelEZ.DAL;
using TravelEZ.Models;

namespace TravelEZ.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private AppContext db = new AppContext();

        public ActionResult Index()
        {
            var activities = from a in db.Activities select a;

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "About Us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //added 3/17/16 rls to reach SearchResults page
        //[HttpGet]
        public ActionResult SearchResults(String activityDropDown, String orgDrop, String stateDropDown)
        {
            ViewBag.Message = "Search Results";

            ViewBag.activity = activityDropDown;
            ViewBag.organization = orgDrop;
            ViewBag.state = stateDropDown;

            int garbage;
            if ( ViewBag.activity == null || ViewBag.activity == System.String.Empty || !int.TryParse( ViewBag.activity, out garbage ) )
            {
                ViewBag.activity = "invalid";
            }
            if ( ViewBag.organization == null || ViewBag.organization == System.String.Empty || !int.TryParse( ViewBag.organization, out garbage ) )
            {
                ViewBag.organization = "invalid";
            }
            if ( ViewBag.state == null || ViewBag.state == System.String.Empty || ViewBag.state.Length != 2 )
            {
                ViewBag.state = "invalid";
            }

            return View();
        }

       


        //Added to follow tutorial for consuming api 2/26/16 rls

        public ActionResult ListActivities()
        {
            return View();
        }

        //Added for tutorial 2/16/16 rls
        public JsonResult GetActivities()//called from view
        {
            ActivityList act = new ActivityList();

            return Json(act.getActivityList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetActivity(string ID)
        {
            Activity act = new Activity();

            return Json(act.getActivity(ID), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOrganization (string ID)
        {
            Organization org = new Organization();
            return Json(org.getOrganization(ID), JsonRequestBehavior.AllowGet);
        }

        /* Nominatim's usage policy is at https://wiki.openstreetmap.org/wiki/Nominatim_usage_policy
         * Particularly worth noting is the 'no heavy uses' requirement: "an absolute maximum of 1 request per second"*/
        private DateTime lastTime = new DateTime(0);
        public JsonResult GetCoordinatesFromAddress(string query, string limit, string passback)
        {
            while( DateTime.Now.CompareTo( lastTime.AddSeconds(1) ) < 0 ) {
                //In theory, this while loop should be an effective rate limiter. In practice, it's not something I want to put to the test.
            }
            lastTime = DateTime.Now;

            Coordinates c = new Coordinates();

            return Json(c.getCoordinates( query, limit, passback ), JsonRequestBehavior.AllowGet);
        }

        /*If no ID is provided: gets ALL addresses of ALL rec areas
         * If an ID is provided: gets ALL addresses of ONE PARTICULAR rec area*/
        public JsonResult GetRecAreaAddresses(string offset, string id, string passback)
        {
            RecAddressList rec = new RecAddressList();

            return Json(rec.getRecAddressList( offset, id, passback ), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRecList( string OFFSET )
        {
            RecList rec = new RecList();

            return Json(rec.getRecList(OFFSET), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRecNames()
        {
            RecName recn = new RecName();

            return Json(recn.getRecNames(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRecActs(int rid)
        {
            RecActs reca = new RecActs();

            return Json(reca.getRecActs(rid), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOrgs()
        {
            Organizations org = new Organizations();

            return Json(org.getOrgs(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetActivityList()
        {
            List<ListItem> activityList = new List<ListItem>()
            {

            };
            return this.Json(activityList);
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