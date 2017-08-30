using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_RdStation.Models
{
    public class LeadsRepositorio : ILeadsRepositorio
    {
        // TODO: Leads --> IEnumerable<Leads> ??????
        private Leads leads = new Leads();

        public LeadsRepositorio()
        {
            leads = (Leads)(new LeadRepositorio().GetAll());
        }

        public Leads Get()
        {
            return leads;
        }

        public void Remove()
        {
            leads = null;
        }

        public bool Update(Leads leads)
        {
            if (leads == null)
            {
                throw new ArgumentNullException("leads");
            }
            this.leads = leads;
            return true;
        }
    }
}