using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TravelEZ.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TravelEZ.DAL
{
    public class AppInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AppContext>
    {
        bool AddUserAndRole(ApplicationDbContext context)  //this maybe belongs somewhere else....//changed
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            ir = rm.Create(new IdentityRole("Banned"));
            ir = rm.Create(new IdentityRole("Admin"));
            //ir = rm.Create(new IdentityRole("Tester"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "bytesizetech@mail.wou.edu",//changed from admin@alienabductionnetwork.com bc can't confirm user w fake email
                Email = "bytesizetech@mail.wou.edu",
                FirstName = "Admin",
                LastName = "Admin",
                HomeTown = "Nowhere"
            };
            ir = um.Create(user, "Abc123!!"); //P_assw0rd1
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "admin");//changed canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(AppContext context)
        {
           //base.Seed(context);
            //By passing a new created context, the created roles do not get saved. At least that is my guess. --SH 2/22/2016
            AddUserAndRole(new ApplicationDbContext());

            var activities = new List<Activity> {
                new Activity{Name="AUTO TOURING", Location="Indianapolis", ActivityLevel=3},
                new Activity{Name="Chess", Location="Portland", ActivityLevel=1 },
                new Activity{Name="Hiking", Location="Seattle", ActivityLevel=5},
                new Activity{Name="Music", Location="Salem", ActivityLevel=2},
                new Activity{Name="Food", Location="Columbus", ActivityLevel=1},
                new Activity{Name="Sports", Location="Los Angeles", ActivityLevel=4},
                new Activity{Name="Biking", Location="New York City", ActivityLevel=4},
                new Activity{Name="Walking", Location="Phoneix", ActivityLevel=4},
                new Activity{Name="Planking", Location="Portland", ActivityLevel=2}
            };

            activities.ForEach(a => context.Activities.Add(a));
            context.SaveChanges();

            var organizations = new List<Organization>
            {
                new Organization{OrgAbbrevName="BLM", OrgImageURL="blm.gif", OrgJurisdictionType="Federal", OrgName="Bureau of Land Management", OrgType="Department of the Interior", OrgURLAddress="http://www.blm.gov", OrgURLText="testing2"},
                new Organization{OrgAbbrevName="FWS", OrgImageURL="fws.gif", OrgJurisdictionType="Federal", OrgName="Fish and Wildlife Service", OrgType="Department of the Interior", OrgURLAddress="http://www.fws.gov", OrgURLText=""},
                new Organization{OrgAbbrevName="NPS", OrgImageURL="nps.gif", OrgJurisdictionType="Federal", OrgName="National Park Service", OrgType="Department of the Interior", OrgURLAddress="http://www.nps.gov", OrgURLText=""},
            };
            organizations.ForEach(o=>context.Organizations.Add(o));
            context.SaveChanges();

            var profiles = new List<UserProfile>
            {
                new UserProfile{FirstName="John", LastName="Doe", HomeTown="Monmouth", BirthDate=new DateTime(1999, 9, 9), UserID="fake1"},
                new UserProfile{FirstName="Jane", LastName="Dough", HomeTown="Corvallis", BirthDate=new DateTime(1988, 8, 8), UserID="fake2"}
            };
            profiles.ForEach(p => context.UserProfiles.Add(p));
            context.SaveChanges();
        }
    }
}



