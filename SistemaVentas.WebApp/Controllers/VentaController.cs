using Microsoft.AspNetCore.Mvc;

namespace SistemaVentas.WebApp.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult NuevaVenta()
        {
            return View();
        }

        public IActionResult HistorialVenta()
        {
            return View();
        }
    }
}
