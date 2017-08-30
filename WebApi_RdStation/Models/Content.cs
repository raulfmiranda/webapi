using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RdStation.Models
{
    public class Content
    {
        public string identificador { get; set; }
        public string nome { get; set; }
        public string email_lead { get; set; }
        public string telefone { get; set; }
        public string empresa { get; set; }
        public string cargo { get; set; }
    }
}