using Microsoft.AspNetCore.Mvc;
using CreditAdviceAndSavingsSimulator.Models;
using CreditAdviceAndSavingsSimulator.Services;

namespace CreditAdviceAndSavingsSimulator.Controllers
{
    public class SavingsSimulatorController : Controller
    {
        private readonly SavingsSimulationService _service;

        // Constructor que inyecta el servicio de simulación
        public SavingsSimulatorController(SavingsSimulationService service)
        {
            _service = service;
        }

        // GET acción para mostrar el formulario inicial
        public IActionResult Index()
        {
            return View(new SavingsPlanModel()); // Asegúrate de tener un modelo inicializado
        }

        // POST acción para procesar la simulación de ahorros
        [HttpPost]
        public IActionResult Simulate(SavingsPlanModel model)
        {
            // Verifica la validez del modelo
            if (!ModelState.IsValid)
            {
                return View("Index", model); // Retorna al formulario con errores
            }

            // Calcula el ahorro total basado en los datos del modelo
            var totalSavings = _service.SimulateSavings(model.InitialAmount, model.MonthlySavings, model.DurationMonths);
            // Muestra los resultados en una vista específica
            return View("SimulationResult", totalSavings);
        }
    }
}
