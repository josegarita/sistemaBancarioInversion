using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.InterestsUtils;

namespace Model.InterestCalculationStrategy
{
    public class CalculateInterestByTermStrategy : ICalculateInterestTermStrategy
    {
        public InterestResult calculateInterest(TermInterest interest)
        {
            InterestResult result = new InterestResult();

            double annualInterest = interest.AnnualInterest;

            decimal performance = Convert.ToDecimal(interest.Amount) * (Convert.ToDecimal(annualInterest) / 360) * (decimal)(interest.Term);

            result.FinalBalance = performance + interest.Amount;
            result.AnnualInterest = (float) annualInterest;
            result.InterestEarned = performance;

          
            return result;
        }
    }
}
