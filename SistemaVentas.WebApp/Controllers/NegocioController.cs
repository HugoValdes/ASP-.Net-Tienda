using Microsoft.AspNetCore.Mvc;

namespace SistemaVentas.WebApp.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
