using Microsoft.AspNetCore.Mvc;
using CreditAdviceAndSavingsSimulator.Models;
using CreditAdviceAndSavingsSimulator.Services;


namespace CreditAdviceAndSavingsSimulator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
