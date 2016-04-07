using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace TravelEZ.Models
{    
     //This Model does not come from the RIDB API set yet
    public class Activity
    {
        public Object getActivityList( string ID = "" )
        {
            string url = "https://ridb.recreation.gov/api/v1/activities/";

            if (ID != "")
            {
                url +=  ID;
            }

            url += "?apikey=871ADBA1B01947068AB4908152A9D346";

            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;

        }

        public Object getActivity(string ID = "")
        {
            return getActivityList(ID);
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int ActivityLevel { get; set; }
    }
}