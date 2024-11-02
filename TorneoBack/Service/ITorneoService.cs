using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;

namespace TorneoBack.Repository.Contracts
{
    public interface ITorneoService
    {
        bool AddTorneo(Torneo torneo);
    }
}


