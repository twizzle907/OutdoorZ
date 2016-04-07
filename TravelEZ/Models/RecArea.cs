using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class RecArea
    {
        public int RecAreaID { get; set; }
        public int OrgRecAreaID { get; set; }
        public string RecAreaName { get; set; }
        public string RecAreaDescription { get; set; }
        public string RecAreaDirections { get; set; }
        public string RecAreaFeeDescription { get; set; }
        public string RecAreaMapURL { get; set; }
        public string RecAreaReservationURL { get; set; }
        public string RecAreaPhone { get; set; }
        public string RecAreaEmail { get; set; }
        public decimal RecAreaLatitude { get; set; }
        public decimal RecAreaLongitude { get; set; }
        public string Keywords { get; set; }
        public string StayLimit { get; set; }


        /*RecArea
            Recreation area records (e.g. Yosemite National Park, Aldo Leopold Wilderness)
             * *Field Name	Format	Length	Optional	Description**
            RecAreaID	INT		N	RecArea ID
            OrgRecAreaID	INT		Y	The agency's internal Recreation Area ID
            RecAreaName	STRING	256	N	Full Name of the recreational area
            RecAreaDescription	STRING	MAX*	N	Text that describes the recreational area
            RecAreaDirections	STRING	MAX*	Y	Directions to the recreational area
            RecAreaFeeDescription	STRING	MAX*	Y	Text describing monetary charges associated with entrance to or usage of a recreational area
            RecAreaMapURL	STRING	256	Y	Internet address (URL) that hosts the recreational area map
            RecAreaReservationURL	STRING	256	Y	Internet address (URL) for the web site hosting the reservation system
            RecAreaPhone	STRING	256	Y	Phone number for recreational area
            RecAreaEmail	STRING	256	N	Email address of the recreational area
            RecAreaLatitude	DECIMAL		Y	Latitude in decimal degrees -90.0 to 90.0
            RecAreaLongitude	DECIMAL		Y	Longitude in decimal degrees -180.0 to 180.0
            Keywords	STRING	4000	Y	List of keywords for the recreational area
            StayLimit	STRING	500	Y	Details on the stay limits for the recreational area */


    }
}