using TareaCalculadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace TareaCalculadora.Controllers
{
    public class CalculadoraController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Calculadora objCalculadora)
        {
            decimal subtotal = objCalculadora.Precio * objCalculadora.Cantidad;
            decimal total = subtotal * (decimal)1.18;

            ViewData["Message"] = "El costo sin IGV : " + subtotal;
            ViewData["Message2"] = "El costo con IGV : "+total;

            return View("Index");
        }
    }
}
