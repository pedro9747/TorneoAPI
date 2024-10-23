using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;

namespace TorneoBack.Repository
{
    public interface ITorneoRepository
    {
        bool Add(Torneo torneo);
    }
    public class TorneoRepository : ITorneoRepository
    {
        private readonly TorneoContext _context;
        public TorneoRepository(TorneoContext context)
        {
            _context = context;
        }
        public bool Add(Torneo torneo)
        {
            if (torneo != null)
            {
                _context.Torneos.Add(torneo);
                return _context.SaveChanges()>0;
            }
            return false;
        }
    }
}
