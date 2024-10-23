using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TorneoApi.Models;
using TorneoBack.Service;

namespace TorneoApi.Controllers
{
    [ApiController]
    [Route("Apí/[controller]")]
    public class TorneoController : Controller
    {
        private readonly ITorneoService _servicio;

        public TorneoController(ITorneoService servicio)
        {
            _servicio = servicio;
        }

        
        [HttpPost]
        public IActionResult CreateTorneo([FromBody]Torneo torneo)
        {
            try
            {
                if (torneo.FechaInicio>torneo.FechaFin)
                {
                   return BadRequest($"Las fechas no son válidas");
                }

                var torneos = _servicio.AddTorneo(torneo);
                if (torneos == false)
                {
                    return BadRequest($"No se pudo crear el torneo: {torneo}");
                }
                return Ok(torneos);
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
           
      
    }
}
