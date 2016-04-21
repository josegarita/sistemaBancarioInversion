using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.InterestCalculationStrategy;
using Model.InterestsUtils;

namespace Model
{
    public class InterestPerformanceByAmount : AbstractInterestPerformance
    {
        private ICalculateInterestByAmountStrategy _interestStrategy;
        private AmountInterest _interest;

        public InterestPerformanceByAmount(AmountInterest pInterest, ICalculateInterestByAmountStrategy pInterestStrategy)
        {
            _interestStrategy = pInterestStrategy;
            _interest = pInterest;
        }

        public void setStrategy(ICalculateInterestByAmountStrategy pInterestStrategy)
        {
            _interestStrategy = pInterestStrategy;
        }

        public override decimal calculateBalance(int pTermInDays)
        {
           InterestResult result = _interestStrategy.calculateInterest(pTermInDays, _interest);

           _interestEarned = result.InterestEarned;
           _annualInterest = result.AnnualInterest;

           return result.FinalBalance;
            
        }
    }
}
