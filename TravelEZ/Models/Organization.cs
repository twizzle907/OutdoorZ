using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace TravelEZ.Models
{
    public class Organization
    {

        public Object getOrganization(string ID = "")
        {
            return getOrganizationList(ID);
        }

        public Object getOrganizationList(string ID = "")
        {
            string url = "https://ridb.recreation.gov/api/v1/organizations/";

            if (ID != "")
            {
                url += ID;
            }

            url += "?apikey=871ADBA1B01947068AB4908152A9D346";

            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;

        }


        [Key]
        public int OrgID { get; set; }
        public string OrgName { get; set; }
        public string OrgAbbrevName { get; set; }
        public string OrgURLAddress { get; set; }
        public string OrgURLText { get; set; }
        public string OrgImageURL { get; set; }
        public string OrgType { get; set; }
        public string OrgJurisdictionType { get; set; }

        /*
         * Organization
            Organization the recreation area or facility is associated to (e.g. U.S. Forest Service, National Park Service)

            Field Name	Format	Length	Optional	Description
            OrgID	INT		N	Organization ID
            OrgName	STRING	60	N	Full name of organization
            OrgAbbrevName	STRING	20	Y	Abbreviated name of the organization
            OrgURLAddress	STRING	256	N	Internet address (URL) for web site of the organization responsible for submitting and maintaining the data to be exchanged
            OrgURLText	STRING	256	Y	Optional Readable text that provides the URL address link
            OrgImageURL	STRING	256	Y	Internet address (URL) that hosts the sample image or photo of the organization
            OrgType	STRING	40	Y	Organization type
            OrgJurisdictionType	STRING	20	Y	Organization jurisdiction type*/

    }
}