using DPR_CodeTest.Calculators.Interfaces;
using System;

namespace DPR_CodeTest.Calculators
{
    public class InterestCalculator : ICalculator
    {
        public decimal Calculate(decimal bankBalance)
        {
            if (bankBalance < 0)
                throw new ArgumentOutOfRangeException("bankBalance", "Can not calculate interest based on less than 0 balance");
            else if (bankBalance < 1000)
                return CalculateInterestByBalance(bankBalance, 1);
            else if (bankBalance < 5000)
                return CalculateInterestByBalance(bankBalance, 1.5m);
            else if (bankBalance < 10000)
                return CalculateInterestByBalance(bankBalance, 2);
            else if (bankBalance < 50000)
                return CalculateInterestByBalance(bankBalance, 2.5m);
            
            return CalculateInterestByBalance(bankBalance, 3); ;
        }

        private decimal CalculateInterestByBalance(decimal bankBalance, decimal percentInterest)
        {
            var onePercent = bankBalance / 100;
            return Math.Round(onePercent * percentInterest, 2);
        }
    }
}
