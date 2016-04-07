using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class RecAreaFacility
    {
        public int RecAreaFacilityID { get; set; }//REMOVE, not part of API
        public int RecAreaID { get; set; }
        public int FacilityID { get; set; }


        /*
         * RecAreaFacility
            Joins parent recreation areas to child facilities

            Field Name	Format	Length	Optional	Description
            RecAreaID	INT		N	Foreign Key: RecArea RecAreaID
            FacilityID	INT		N	Foreign Key: Facility FacilityID
         * */
    }
}