using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RdStation.Models
{
    public class ConversionOrigin
    {
        public string source { get; set; }
        public string medium { get; set; }
        public string value { get; set; }
        public string campaign { get; set; }
        public string channel { get; set; }
    }
}