
using System.ComponentModel.DataAnnotations;
using CreditAdviceAndSavingsSimulator.Models;
using CreditAdviceAndSavingsSimulator.Services;


namespace CreditAdviceAndSavingsSimulator.Models
{
    public class FinancialDetailsModel
    {   
        public decimal MonthlyIncome { get; set; }
        public decimal TotalDebt { get; set; }
        public decimal MonthlyPayments { get; set; }
    }
}
