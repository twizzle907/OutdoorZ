using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TravelEZ.Models
{
    public class RecInfo
    {
        public int RecInfoID { get; set; } //REMOVE, not part of API
        [DataContract]
        public class RootObject
        {
            public List<RECDATA> RECDATA { get; set; }
            public METADATA METADATA { get; set; }
        }

        public class RECDATA
        {
            public string OrgAbbrevName { get; set; }
            public string OrgJurisdictionType { get; set; }
            public string OrgType { get; set; }
            public string LastUpdatedDate { get; set; }
            public string OrgURLText { get; set; }
            public string OrgURLAddress { get; set; }
            public string OrgImageURL { get; set; }
            public int OrgParentID { get; set; }
            public int OrgID { get; set; }
            public string OrgName { get; set; }
        }

        public class SEARCHPARAMETERS
        {
            public string QUERY { get; set; }
            public int OFFSET { get; set; }
            public int LIMIT { get; set; }
        }

        public class RESULTS
        {
            public int TOTAL_COUNT { get; set; }
            public int CURRENT_COUNT { get; set; }
        }

        public class METADATA
        {
            public SEARCHPARAMETERS SEARCH_PARAMETERS { get; set; }
            public RESULTS RESULTS { get; set; }
        }

        

    }
}