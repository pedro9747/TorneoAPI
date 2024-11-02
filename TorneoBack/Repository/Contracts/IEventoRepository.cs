using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;

namespace TorneoBack.Repository.Contracts
{
    public interface IEventoRepository
    {
        void Add(Evento evento);
        void Delete(int id);
        Evento Get(int id);
        List<Evento> GetAll();
        void Update(Evento evento);
    }
}
