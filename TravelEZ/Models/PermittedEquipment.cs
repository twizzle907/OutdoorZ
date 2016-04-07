using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class PermittedEquipment
    {
        public int PermittedEquipmentID { get; set; }//REMOVE, not part of API
        public string EquipmentName { get; set; }
        public int MaxLength { get; set; }

       /* PermittedEquipment
            Permitted Equipment associated to campsites (e.g. tent, trailer)

            Field Name	Format	Length	Optional	Description
            EquipmentName	STRING	255	N	Equipment Name
            MaxLength	INT		Y	Maximum length of equipment*/
    }
}