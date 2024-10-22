using System;
using System.Collections.Generic;

namespace TorneoApi.Models;

public partial class Equipo
{
    public int IdEquipo { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaFundacion { get; set; }

    public int? IdCiudad { get; set; }

    public virtual ICollection<DirectoresTecnico> DirectoresTecnicos { get; set; } = new List<DirectoresTecnico>();

    public virtual Ciudad? IdCiudadNavigation { get; set; }

    public virtual ICollection<Jugador> Jugadores { get; set; } = new List<Jugador>();

    public virtual ICollection<Partido> PartidoEquipo1Navigations { get; set; } = new List<Partido>();

    public virtual ICollection<Partido> PartidoEquipo2Navigations { get; set; } = new List<Partido>();

    public virtual ICollection<TorneosXEquipo> TorneosXEquipos { get; set; } = new List<TorneosXEquipo>();
}
