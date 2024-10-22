using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;

namespace TorneoBack.Repository
{
    public interface IEventoRepository
    {
        void Add(Evento evento);
        void Delete(int id);
        Evento Get(int id);
        List<Evento> GetAll();
        void Update(Evento evento);
    }
    class EventoRepository : IEventoRepository
    {
        public void Add(Evento evento)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Evento Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Evento evento)
        {
            throw new NotImplementedException();
        }
    }
}
