using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RdStation.Models
{
    public class LastConversion
    {
        public Content2 content { get; set; }
        public string created_at { get; set; }
        public string cumulative_sum { get; set; }
        public string source { get; set; }
    }
}