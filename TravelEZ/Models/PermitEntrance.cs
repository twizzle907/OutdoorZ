using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class PermitEntrance
    {
        public int PermitEntranceID { get; set; }
        public int FacilityID { get; set; }
        public string PermitEntranceName { get; set; }
        public string PermitEntranceType { get; set; }
        public string PermitEntranceDescription { get; set; }
        public string PermitEntranceAccesible { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
        public string Zone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        /*PermitEntrance
            Permit entrance records

            Field Name	Format	Length	Optional	Description
            PermitEntranceID	INT		N	Permit Entrance ID
            FacilityID	INT		N	Facility ID the Permit belongs to
            PermitEntranceName	STRING	512	N	Permit Entrance Name
            PermitEntranceType	STRING	255	Y	Permit Entrance Type
            PermitEntranceDescription	STRING	255	Y	Permit Entrance Description
            PermitEntranceAccesible	STRING	10	Y	Is the permit accessible by vehicle
            Latitude	DECIMAL			Latitude of the permit location
            Longitude	DECIMAL			Longitude of the permit location
            District	STRING	60	Y	District the permit resides in
            Town	STRING	60	Y	Town the permit resides in
            Zone	STRING	255	Y	Zone the permit resides in
            CreatedDate	DATETIME		N	Record creation date
            LastUpdatedDate	DATETIME		N	Record last update date*/

    }
}