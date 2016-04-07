using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class EntityMedia
    {
        public int EntityMediaID { get; set; }//REMOVE, not part of API
        public string EntityType { get; set; }
        public int EntityID { get; set; }
        public string MediaType { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string Credits { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string EmbedCode { get; set; }


        /*
         * EntityMedia
            Media links (e.g. images, video)

            Field Name	Format	Length	Optional	Description
            EntityType	STRING	50	N	RecArea, Facility, Tour, Entrance, or Site
            EntityID	INT		N	Foreign Key: (RecArea RecAreaID) OR (Facility FacilityID) OR (Tour TourID) OR (PermitEntrance PermitEntranceID) OR (Campsite CampsiteID)
            MediaType	STRING	500	N	Type of Media, e.g. Image, Video, etc.
            URL	STRING	2000	N	Internet address (URL) to the entity media
            Title	STRING	500	N	Full title of the entity media
            Subtitle	STRING	1000	Y	Optional subtitle of the entity media
            Description	STRING	MAX*	Y	Optional description of the entity media
            Credits	STRING	1000	Y	Optional credit for entity media
            Height	INT		N	Height in pixels for media image
            Width	INT		N	Width in pixels for the media image
            EmbedCode	STRING	MAX*	Y	Optional embedded code for media entity
         */

    }
}