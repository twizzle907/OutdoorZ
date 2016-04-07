using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class Tour
    {
        public int TourID { get; set; }
        public int FacilityID { get; set; }
        public string TourName { get; set; }
        public string TourType { get; set; }
        public string TourDescription { get; set; }
        public int TourDuration { get; set; }
        public string TourAccessible { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        /*
         * Tour
            Tour records

            Field Name	Format	Length	Optional	Description
            TourID	INT		N	Tour ID
            FacilityID	INT		N	Facility ID the tour belongs to
            TourName	STRING	255	N	Tour name
            TourType	STRING	255	Y	Tour Type
            TourDescription	STRING	255	Y	Tour description
            TourDuration	INT		Y	Tour duration
            TourAccessible	STRING	10	Y	Is the tour accessible by vehicle
            CreatedDate	DATETIME		N	Record creation date
            LastUpdatedDate	DATETIME		N	Record last update date
         */

    }
}