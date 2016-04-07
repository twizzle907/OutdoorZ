using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class Facility
    {
        public int FacilityID {get; set;}
        public int OrgFacilityID {get; set;}
        public string  FacilityName{get; set;}
        public string FacilityTypeDescription {get; set;}
        public string FacilityPhone {get; set;}
        public string FacilityDescription {get; set;}
        public string FacilityDirections {get; set;}
        public string FacilityEmail {get; set;}
        public string FacilityMapURL {get; set;}
        public string FacilityReservationURL {get; set;}
        public decimal FacilityLatitude {get; set;}
        public decimal FacilityLongitude {get; set;}
        public string FacilityAdaAccess {get; set;}
        public string FacilityUseFeeDescription {get; set;}
        public string LegacyFacilityID {get; set;}
        public string Keywords {get; set;}
        public string StayLimit {get; set;}
        /*
         * 
        Facility
            Facility records (e.g. Yellowstone Group Campground, Barnum Whitewater Area)

            Field Name	Format	Length	Optional	Description
            FacilityID	INT		N	Facility ID
            OrgFacilityID	INT		N	The agency's internal Facility ID
            FacilityName	STRING	256	N	Full name of the facility
            FacilityTypeDescription	STRING	1024	Y	Description of the type of facility
            FacilityPhone	STRING	256	Y	Phone number of the facility
            FacilityDescription	STRING	MAX*	N	Text describing the main features of the facility
            FacilityDirections	STRING	MAX*	Y	Text that provides general directions and/or the general location of the facility
            FacilityEmail	STRING	60	Y	Email address of the facility
            FacilityMapURL	STRING	256	Y	Internet address (URL) that hosts the facility map
            FacilityReservationURL	STRING	256	Y	Internet address (URL) for the web site hosting the reservation system
            FacilityLatitude	DECIMAL		Y	Latitude in decimal degrees -90.0 to 90.0
            FacilityLongitude	DECIMAL		Y	Longitude in decimal degrees -180.0 to 180.0
            FacilityAdaAccess	STRING	1024	Y	Information about the Americans with Disabilities Act accessibility for the facility
            FacilityUseFeeDescription	STRING	MAX*	Y	Text describing monetary charges associated with entrance to or usage of the facility
            LegacyFacilityID	STRING	20	Y	Legacy facility ID
            Keywords	STRING	4000	Y	List of keywords for the facility
            StayLimit	STRING	500	Y	Details on the stay limits for the facility
         */
    }
}