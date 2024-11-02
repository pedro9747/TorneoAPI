using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TorneoApi.Models;
using TorneoBack.Repository.Contracts;
using TorneoBack.Service;

namespace TorneoApi.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class TorneoController : Controller
    {
        private readonly ITorneoService _servicio;

        public TorneoController(ITorneoService servicio)
        {
            _servicio = servicio;
        }

        
        [HttpPost]
        public IActionResult CreateTorneo([FromBody] Torneo torneo)
        {
            try
            {
                if (torneo.FechaInicio > torneo.FechaFin)
                {
                    return BadRequest("La fecha de inicio no puede ser posterior a la fecha de finalización.");
                }

                bool torneoCreado = _servicio.AddTorneo(torneo);

                if (!torneoCreado)
                {
                    return BadRequest($"No se pudo crear el torneo '{torneo.Nombre}'. Verifique los datos e intente nuevamente.");
                }

                return Ok(new { mensaje = "Torneo creado exitosamente.", torneo });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


    }
}
