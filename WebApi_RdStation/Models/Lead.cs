using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RdStation.Models
{
    public class Lead
    {
        public string id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string job_title { get; set; }
        public string bio { get; set; }
        public string public_url { get; set; }
        public string created_at { get; set; }
        public string opportunity { get; set; }
        public string number_conversions { get; set; }
        public string user { get; set; }
        public FirstConversion first_conversion { get; set; }
        public LastConversion last_conversion { get; set; }
        public CustomFields custom_fields { get; set; }
        public string website { get; set; }
        public string personal_phone { get; set; }
        public string mobile_phone { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string lead_stage { get; set; }
        public List<string> tags { get; set; }
        public string fit_score { get; set; }
        public int interest { get; set; }
    }
}