using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace TravelEZ.DAL
{
    public class RIDBApiClient
    {

        public static void getRIDBData()//probably shouldn't be static later
        {
            //var url = "https://ridb.recreation.gov/api/v1/organizations/?apikey=871ADBA1B01947068AB4908152A9D346";
            string domain = "https://ridb.recreation.gov";
            string location = "/api/v1/organizations/?apikey=";
            string key = "871ADBA1B01947068AB4908152A9D346";
            string url = domain + location + key;

            //Synchronious Consumption
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            //Create serializer and get response
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TravelEZ.Models.RecInfo));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var information = (TravelEZ.Models.RecInfo)serializer.ReadObject(ms);
            }
        }
    }
}