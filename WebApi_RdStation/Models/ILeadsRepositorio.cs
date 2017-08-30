using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_RdStation.Models
{
    interface ILeadsRepositorio
    {
        Leads Get();
        void Remove();
        bool Update(Leads leads);
    }
}
