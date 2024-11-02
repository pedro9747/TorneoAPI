using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;

namespace TorneoBack.Repository.Contracts
{
    public interface IEquiposRepository
    {
        bool AddEquipo(Equipo equipo);
        List<Equipo> GetAll();
    }
}
