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
    public class RecList
    {
        public Object getRecList( string OFFSET = "" )
        {
            string url = "https://ridb.recreation.gov/api/v1/recareas/?apikey=871ADBA1B01947068AB4908152A9D346";

            if (OFFSET != null && OFFSET != "")
            {
                url += "&OFFSET=" + OFFSET;
            }

            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;

        }

    }
}