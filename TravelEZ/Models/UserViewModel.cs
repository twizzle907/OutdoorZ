using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelEZ.Models
{
    public class ListUserViewModel
    {
        public List<UserViewModel> Users { get; set; }
        //public List<UserViewModel> Admins { get; set; }
    }

    public class UserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        //public bool isBanned { get; set; }
        //public string Roles { get; set; }
    }
}