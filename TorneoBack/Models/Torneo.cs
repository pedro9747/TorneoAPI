using System;
using System.Collections.Generic;

namespace TorneoApi.Models;

public partial class Torneo
{
    public int IdTorneo { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<Partido> Partidos { get; set; } = new List<Partido>();

    public virtual ICollection<TorneosXEquipo> TorneosXEquipos { get; set; } = new List<TorneosXEquipo>();
}
