using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class EntityLink
    {
        public int EntityLinkID { get; set; }//REMOVE, not part of API
        public string EntityType { get; set; }
        public int EntityID { get; set; }
        public string LinkType { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        /*EntityLink
            Hyperlink to an external site (e.g. Agency site, Facebook, Twitter)

            Field Name	Format	Length	Optional	Description
            EntityType	STRING	50	N	RecArea or Facility
            EntityID	INT		N	Foreign Key: (RecArea RecAreaID) OR (Facility FacilityID)
            LinkType	STRING	500	N	Type of link, e.g. Facebook, Twitter, Official site
            URL	STRING	2000	N	Internet address (URL) to a web site
            Title	STRING	500	N	Full text title
            Description	STRING	MAX*	Y	Text description of the entity link*/
    }
}