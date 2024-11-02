using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;

namespace TorneoBack.Repository.Contracts
{
    public interface IJugadorRepository
    {
        void Add(Jugador jugador);
        void Delete(int id);
        Jugador Get(int id);
        IEnumerable<Jugador> GetAll();
        void Update(Jugador jugador);
    }
}