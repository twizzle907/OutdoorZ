using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class RecAreaAddress
    {
        public int RecAreaAddressID { get; set; }//REMOVE, not part of API
        public int AddressID { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string StreetAddress3 { get; set; }
        public string City { get; set; }
        public string AddressStateCode { get; set; }
        public string PostalCode { get; set; }
        public string AddressCountryCode { get; set; }
        public int RecAreaID { get; set; }
        public string RecAreaAddressType { get; set; }

        /*
         * RecAreaAddress
            Recreation area addresses

            Field Name	Format	Length	Optional	Description
            AddressID	INT		N	Address ID
            StreetAddress1	STRING	256	Y	Address Line 1 of the recreational area
            StreetAddress2	STRING	256	Y	Address Line 2 of the recreational area
            StreetAddress3	STRING	256	Y	Address Line 3 of the recreational area
            City	STRING	60	Y	City where the recreational area is located
            AddressStateCode	STRING	20	N	State code for the recreational area
            PostalCode	STRING	20	Y	Postal code for the recreational area
            AddressCountryCode	STRING	5	Y	Abbreviated country code for the recreational area address
            RecAreaID	INT		N	Foreign Key: RecArea RecAreaID
            RecAreaAddressType	STRING	20	Y	Address Type for the recreational area
         * */
    }
}