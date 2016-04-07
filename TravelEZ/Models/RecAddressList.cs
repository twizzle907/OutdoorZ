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
    public class RecAddressList
    {
        /* Function getRecAddressList: If no ID is provided: gets ALL addresses of ALL rec areas
         * If an ID is provided: gets ALL addresses of ONE PARTICULAR rec area
         * Arguments:
         * -- offset: A string representing an offset into RIDB: offset 50, for example, will cause it to ignore the first 50 results.
         * -- id: A string containing an integer representing the rec area whose addresses we are seeking.
         * -- passback: A string to be returned to the callback function (appended to the JSON content). Can contain anything, such as an ID number or a name; it's up to you.
         */
        public Object getRecAddressList( string offset = "", string id = "", string passback = "" )
        {
            string url = "https://ridb.recreation.gov/api/v1/";

            if (id != null && id != "")
            {
                url += "recareas/" + id + "/";
            }

            url += "recareaaddresses/?apikey=871ADBA1B01947068AB4908152A9D346";

            if (offset != null && offset != "")
            {
                url += "&OFFSET=" + offset;
            }

            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Dictionary<string,Object>>(content);
            jsonContent.Add("passback", passback);

            return jsonContent;

        }

    }
}