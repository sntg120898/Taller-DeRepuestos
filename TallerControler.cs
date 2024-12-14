namespace TallerRepuestosASP.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TallerRepuestosASP.Models;

    public class TallerController : Controller
    {
        private static Taller _taller = new Taller();

        public IActionResult Index()
        {
            return View(_taller);
        }

        public IActionResult AgregarRepuesto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarRepuesto(Repuesto repuesto)
        {
            _taller.AgregarRepuesto(repuesto);
            return RedirectToAction("Index");
        }

        public IActionResult BuscarRepuesto(string termino)
        {
            var resultados = _taller.BuscarRepuesto(termino);
            return View(resultados);
        }
    }
}