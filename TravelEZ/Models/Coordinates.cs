using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace TravelEZ.Models
{
    public class Coordinates
    {
        /* Function getCoordinates: Looks up an item in OpenStreetMap via their Nominatim API.
         * 
         * Note: Nominatim's usage policy is at https://wiki.openstreetmap.org/wiki/Nominatim_usage_policy
         * Particularly worth noting is the 'no heavy uses' requirement: "an absolute maximum of 1 request per second
         * 
         * Arguments:
         * -- query: The query string passed to Nominatim
         * -- limit: A string containing an integer representing the maximum number of results Nominatim should return to us.
         * -- passback: A string to be returned to the callback function (appended to the JSON content). Can contain anything, such as an ID number or a name; it's up to you.
         * */
        public Object getCoordinates( string query = "", string limit = "", string passback = "" )
        {
            string url = "https://nominatim.openstreetmap.org/search?format=jsonv2&email=ByteSizeTech@mail.wou.edu";

            if (query != null && query != "")
            {
                url += "&q=" + query;
            }
            if (limit != null && limit != "")
            {
                url += "&limit=" + limit;
            }

            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<List<Object>>(content);
            jsonContent.Add(passback);

            return jsonContent;

        }

    }
}