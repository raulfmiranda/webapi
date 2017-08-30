using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_RdStation.Models;

namespace WebApi_RdStation.Controllers
{
    public class LeadController : ApiController
    {
        static readonly ILeadRepositorio repositorio = new LeadRepositorio();

        public IEnumerable<Lead> GetAllLeads()
        {
            return repositorio.GetAll();
        }

        public Lead GetLead(string id)
        {
            Lead lead = repositorio.Get(id);
            if (lead == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return lead;
        }

        public HttpResponseMessage PostLead(Lead lead)
        {
            lead = repositorio.Add(lead);
            var response = Request.CreateResponse<Lead>(HttpStatusCode.Created, lead);

            string uri = Url.Link("DefaultApi", new { id = lead.id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutLead(string id, Lead lead)
        {
            lead.id = id;
            if (!repositorio.Update(lead))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeleteLead(string id)
        {
            Lead lead = repositorio.Get(id);

            if (lead == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Remove(id);
        }
    }
}
