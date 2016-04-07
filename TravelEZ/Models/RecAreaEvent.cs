using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class RecAreaEvent
    {
        public int RecAreaEventID { get; set; }//REMOVE, not part of API
        public int RecAreaID { get; set; }
        public int EventID { get; set; }
        /*
         *RecAreaEvent
            Joins recreation areas to associated events

            Field Name	Format	Length	Optional	Description
            RecAreaID	INT		N	Foreign Key: RecArea RecAreaID
            EventID	INT		N	Foreign Key: Event EventID 
         */
    }
}