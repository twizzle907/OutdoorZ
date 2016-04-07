using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class RecreationalActivity
    {
        public int RecreationalActivityID { get; set; }//REMOVE, not part of API
        public int ActivityID { get; set; }
        public string RecActivityName { get; set; }
        public int RecActivityLevel { get; set; }
        /*
         *RecreationalActivity
            List of all activities

            Field Name	Format	Length	Optional	Description
            ActivityID	INT		N	Activity ID
            RecActivityName	STRING	60	N	Name of the activity
            RecActivityLevel	INT		N	Amount of physical exertion to be expected for a given activity such as hiking, swimming, etc 
         */
    }
}