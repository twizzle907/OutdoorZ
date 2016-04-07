using TravelEZ.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.DAL
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("AppContext")
        {
        }

        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Campsite> Campsites { get; set; }
        public DbSet<EntityActivity> EntityActivities { get; set; }
        public DbSet<EntityLink> EntityLinks { get; set; }
        public DbSet<EntityMedia> EntityMedias { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Facility> Facilties { get; set; }
        public DbSet<FacilityAddress> FacilityAddresses { get; set; }
        public DbSet<FacilityEvent> FacilityEvents { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrgEntity> OrgEntities { get; set; }
        public DbSet<PermitEntrance> PermitEntrances { get; set; }
        public DbSet<PermittedEquipment> PermittedEquipments { get; set; }
        public DbSet<RecArea> RecAreas { get; set; }
        public DbSet<RecAreaAddress> RecAreaAddresses { get; set; }
        public DbSet<RecAreaEvent> RecAreaEvents { get; set; }
        public DbSet<RecAreaFacility> RecAreaFacilities { get; set; }
        public DbSet<RecInfo> RecInfos { get; set; }
        public DbSet<RecreationalActivity> RecreationalActivities { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

       // public DbSet<BannedUser> BannedUsers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<TravelEZ.Models.BannedUser> BannedUsers { get; set; }
    }

}