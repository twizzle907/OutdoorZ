using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class OrgEntity
    {
        public int OrgEntityID { get; set; }//REMOVE, not part of API
        public int EntityID { get; set; }
        public string EntityType { get; set; }
        public int OrgID { get; set; }
        /*OrgEntity
            Relationship between organizations and recreation areas, and facilities
         ** Field Name	Format	Length	Optional	Description**
            EntityID	INT		N	RecArea ID or Facility ID
            EntityType	STRING	1024	N	"Facility" or "RecArea"
            OrgID	INT		N	The organization ID*/
    }
}