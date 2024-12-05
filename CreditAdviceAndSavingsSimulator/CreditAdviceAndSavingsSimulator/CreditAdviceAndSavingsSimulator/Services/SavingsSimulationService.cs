using System;

namespace CreditAdviceAndSavingsSimulator.Services
{
    public class SavingsSimulationService
    {
        public decimal SimulateSavings(decimal initialAmount, decimal monthlySavings, int durationMonths)
        {
            decimal totalSavings = initialAmount;

            for (int i = 0; i < durationMonths; i++)
            {
                totalSavings += monthlySavings;
            }

            return totalSavings;
        }
    }
}
