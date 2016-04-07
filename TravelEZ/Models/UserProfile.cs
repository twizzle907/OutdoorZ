using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class UserProfile
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserID { get; set; }
    }
}