using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RdStation.Models
{
    public class FirstConversion
    {
        public Content content { get; set; }
        public string created_at { get; set; }
        public string cumulative_sum { get; set; }
        public string source { get; set; }
        public ConversionOrigin conversion_origin { get; set; }
    }
}