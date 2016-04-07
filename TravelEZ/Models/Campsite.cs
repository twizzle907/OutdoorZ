using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class Campsite
    {
        public int CampsiteID {get; set;}
        public int FacilityID { get; set; }
        public string CampsiteName { get; set; }
        public string CampsiteType { get; set; }
        public string Loop { get; set; }
        public string TypeofUse {get; set;} //there were spaces in this name, I removed them
        public string CampsiteAccesible { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        /*
         * Campsite
            Campsite records

            Field Name	Format	Length	Optional	Description
            CampsiteID	INT		N	Campsite ID
            FacilityID	INT		N	Facility ID the campsite belongs to
            CampsiteName	STRING	255	N	Campsite Name
            CampsiteType	STRING	255	Y	Campsite Type
            Loop	STRING	255	Y	Name of loop the campsite resides on
            Type of Use	STRING	255	Y	Type of use
            CampsiteAccesible	STRING	10	Y	Is the campsite accessible by vehicle
            CreatedDate	DATETIME		N	Record creation date
            LastUpdateDate	DATETIME		N	Record last update date
         */
    }
}