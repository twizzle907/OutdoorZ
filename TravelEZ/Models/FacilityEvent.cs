using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class FacilityEvent
    {
        public int FacilityEventID { get; set; }//REMOVE, not part of API
        public int FacilityID { get; set; }
        public int EventID { get; set; }

        /*
         * FacilityEvent
            Joins facilities to associated events

            Field Name	Format	Length	Optional	Description
            FacilityID	INT		N	Foreign Key: Facility FacilityID
            EventID	INT		N	Foreign Key: Event EventID
         * */
    }
}