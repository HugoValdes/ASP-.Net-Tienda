using Microsoft.AspNetCore.Mvc;

namespace SistemaVentas.WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
