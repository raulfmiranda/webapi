using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_RdStation.Models
{
    interface ILeadRepositorio
    {
        IEnumerable<Lead> GetAll();
        Lead Get(string id);
        Lead Add(Lead lead);
        void Remove(string id);
        bool Update(Lead lead);
    }
}
