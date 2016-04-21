using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.InterestsUtils;

namespace Model.InterestCalculationStrategy
{
    public class CalculateInterestByAmountStrategy : ICalculateInterestAmountStrategy
    {
        public InterestResult calculateInterest(int pCantDias, AmountInterest interest)
        {
            InterestResult result = new InterestResult();

            double annualInterest = interest.AnnualInterest;
          
            decimal performance = interest.Amount * (decimal)(annualInterest / 360) * (decimal) pCantDias;

            result.FinalBalance = interest.Amount + performance;
            result.AnnualInterest = annualInterest;
            result.InterestEarned = performance;

            return result;
        }
    }
}
