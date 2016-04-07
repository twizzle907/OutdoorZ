using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class FacilityAddress
    {
        public int FacilityAddressID { get; set; }//REMOVE, not part of API
        public int AddressID { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string StreetAddress3 { get; set; }
        public string City { get; set; }
        public string AddressStateCode { get; set; }
        public string PostalCode { get; set; }
        public string AddressCountryCode { get; set; }
        public int FacilityID { get; set; }
        public string FacilityAddressType { get; set; }

        /*
         * FacilityAddress
            Facility addresses

            Field Name	Format	Length	Optional	Description
            AddressID	INT		N	Address ID
            StreetAddress1	STRING	256	Y	Address Line 1 of the facility
            StreetAddress2	STRING	256	Y	Address Line 2 of the facility
            StreetAddress3	STRING	256	Y	Address Line 3 of the facility
            City	STRING	60	Y	City where the facility is located
            AddressStateCode	STRING	20	N	State code for the facility
            PostalCode	STRING	20	Y	Postal code for the facility
            AddressCountryCode	STRING	5	Y	Abbreviated country code for the facility address
            FacilityID	INT		N	Foreign Key: Facility FacilityID
            FacilityAddressType	STRING	20	Y	Address type for the facility
         * */
    }
}