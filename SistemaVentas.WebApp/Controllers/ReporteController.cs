using Microsoft.AspNetCore.Mvc;

namespace SistemaVentas.WebApp.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult ReporteVenta()
        {
            return View();
        }
    }
}
