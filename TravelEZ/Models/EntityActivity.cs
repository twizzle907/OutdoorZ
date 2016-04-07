using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelEZ.Models
{
    public class EntityActivity
    {
        public int EntityActivityID { get; set; } //this will need to be removed not part of API
        public int EntityID { get; set; } 
        public string EntityType { get; set; }
        public int ActivityID { get; set; }
        public string ActivityDescription { get; set; }
        public string ActivityFeeDescription { get; set; }


        /*EntityActivity
            Joins recreation areas and facilities to associated activities

            Field Name	Format	Length	Optional	Description
            EntityID	INT		N	Foreign Key: RecArea RecAreaID or Facility FacilityID
            EntityType	STRING	1024	N	Entity Type. "RecArea" or "Facility"
            ActivityID	INT		N	Foreign Key: RecreationalActivity ActivityID
            ActivityDescription	STRING	1024	Y	Description of the activity
            ActivityFeeDescription	STRING	1024	Y	Text describing monetary charges associated with the activity
         * 
         * */
    }
}