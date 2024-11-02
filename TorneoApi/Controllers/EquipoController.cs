using Microsoft.AspNetCore.Mvc;

namespace TorneoApi.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
