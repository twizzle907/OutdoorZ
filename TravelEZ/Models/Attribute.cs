using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class Attribute
    {
        public int AttributeID { get; set; } //this will need to be removed not part of API
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        /*
         *Attribute
            Attributes associated to campsites, tours, and permit entrances (e.g. checkout time, shade, water hookup)

            Field Name	Format	Length	Optional	Description
            AttributeName	STRING	60	Y	Attribute name
            AttributeValue	STRING	255	Y	Attribute value
         * */

    }
}