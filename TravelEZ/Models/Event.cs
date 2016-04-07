using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public int EntityID { get; set; }
        public string EntityType { get; set; }
        public int EventDataStewardID { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartDate { get; set; }
        public string EventDescription { get; set; }
        public string EventAgeGroup { get; set; }
        public string EventURLAddress { get; set; }
        public string EventURLText { get; set; }
        public string EventEmail { get; set; }
        public Boolean EventRegistrationRequired { get; set; }
        public string EventADAAccess { get; set; }
        public string EventFeeDescription { get; set; }
        public string EventComments { get; set; }
        public string EventFrequencyRateDescription { get; set; }
        public string EventScopeDescription { get; set; }
        public string EventTypeDescription { get; set; }
        public string SponsorName { get; set; }
        public string SponsorEmail { get; set; }
        public string SponsorURLAddress { get; set; }
        public DateTime EventEndDate { get; set; }
        public string SponsorURLText { get; set; }
        public string SponsorPhone { get; set; }
        public string SponsorClassType { get; set; }
        /*
         * 
         Event
            List of all events (e.g. Boat race, Archery Tournament)

            Field Name	Format	Length	Optional	Description
            EventID	INT		N	Event ID
            EntityID	INT		N	Foreign Key: Facility FacilityID or RecArea RecAreaID
            EntityType	STRING	1024	N	"Facility" or "RecArea"
            EventDataStewardID	INT		Y	Data Steward ID for the event
            EventName	STRING	60	N	Full Name of the event
            EventStartDate	DATETIME		N	Calendar date on which event is scheduled to begin
            EventDescription	STRING	1024	N	Text that provides a synopsis of an event
            EventAgeGroup	STRING	20	Y	Age group for the event if available
            EventURLAddress	STRING	256	Y	Internet address (URL) to a web site providing details about the event
            EventURLText	STRING	256	Y	Optional text for the URL of the event
            EventEmail	STRING	60	Y	Email contact for event
            EventRegistrationRequired	BIT		N	Code requesting a Yes or No response to determine whether registration is required for an event
            EventADAAccess	STRING	1024	Y	Information about the Americans with Disabilities Act accessibility for the event
            EventFeeDescription	STRING	1024	Y	Text for the description of fees associated with this event
            EventComments	STRING	1024	Y	Text for the general occasion or activity to be offered
            EventFrequencyRateDescription	STRING	1024	Y	Text that describes how often the event recurs
            EventScopeDescription	STRING	1024	Y	Text that describes the extent, capacity, and scale of an event.
            EventTypeDescription	STRING	1024	Y	Text that describes the types of events
            SponsorName	STRING	60	Y	Full Name of the sponsor for the event
            SponsorEmail	STRING	60	Y	Sponsor email address for the event
            SponsorURLAddress	STRING	256	Y	Internet address (URL) to a web site for the sponsor
            EventEndDate	DATETIME		N	Calendar date on which event is scheduled to end
            SponsorURLText	STRING	256	Y	Optional Readable text that provides the URL Sponsor link
            SponsorPhone	STRING	20	Y	Phone Number for the sponsor of the Event
            SponsorClassType	STRING	20	Y	Class and type of sponsor
           
           
           
           
         * */
    }
}