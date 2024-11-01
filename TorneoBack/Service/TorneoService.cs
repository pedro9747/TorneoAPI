using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;
using TorneoBack.Repository;

namespace TorneoBack.Service
{
   
    public class TorneoService : ITorneoService
    {
        private readonly ITorneoRepository _torneoRepository;
        public TorneoService(ITorneoRepository torneoRepository)
        {
            _torneoRepository = torneoRepository;
        }
        public bool AddTorneo(Torneo torneo)
        {
            return _torneoRepository.Add(torneo);
        }
    }
}
