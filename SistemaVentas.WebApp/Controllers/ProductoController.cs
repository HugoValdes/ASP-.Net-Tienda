using Microsoft.AspNetCore.Mvc;

namespace SistemaVentas.WebApp.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
