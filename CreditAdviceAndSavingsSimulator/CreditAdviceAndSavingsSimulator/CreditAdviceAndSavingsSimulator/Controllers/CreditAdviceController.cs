using Microsoft.AspNetCore.Mvc;
using CreditAdviceAndSavingsSimulator.Models;
using CreditAdviceAndSavingsSimulator.Services;

namespace CreditAdviceAndSavingsSimulator.Controllers
{
    public class CreditAdviceController : Controller
    {
        private readonly CreditAdviceService _creditService;

        public CreditAdviceController(CreditAdviceService creditService)
        {
            _creditService = creditService;
        }

        public IActionResult Index()
        {
            return View(new FinancialDetailsModel());
        }

        [HttpPost]
        public async Task<IActionResult> GenerateAdvice(FinancialDetailsModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            var prompt = $"How can someone with a monthly income of {model.MonthlyIncome}, total debt of {model.TotalDebt}, and monthly payments of {model.MonthlyPayments} improve their credit score?";
            var advice = await _creditService.GetCreditAdvice(prompt);
            return View("AdviceResult", advice);
        }
    }
}
