using System.ComponentModel.DataAnnotations;
using CreditAdviceAndSavingsSimulator.Models;
using CreditAdviceAndSavingsSimulator.Services;



// SavingsPlanModel.cs ubicado en la carpeta Models

namespace CreditAdviceAndSavingsSimulator.Models
{
    public class SavingsPlanModel
    {
        public decimal InitialAmount { get; set; }
        public decimal MonthlySavings { get; set; }
        public int DurationMonths { get; set; }
    }
}

