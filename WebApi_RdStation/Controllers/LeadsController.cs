using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_RdStation.Models;

namespace WebApi_RdStation.Controllers
{
    public class LeadsController : ApiController
    {
        static readonly ILeadsRepositorio repositorio = new LeadsRepositorio();

        public Leads GetLeads()
        {
            return repositorio.Get();
        }

        public void PutLeads(Leads leads)
        {
            if (!repositorio.Update(leads))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
    }

}
