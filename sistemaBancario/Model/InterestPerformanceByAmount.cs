using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.InterestCalculationStrategy;

namespace Model
{
    class InterestPerformanceByAmount : AbstractInterestPerformance
    {
        ICalculateInterestByAmountStrategy _interestStrategy;

        public InterestPerformanceByAmount(ICalculateInterestByAmountStrategy interestStrategy)
        {
            _interestStrategy = interestStrategy;
        }

        public void setStrategy(ICalculateInterestByAmountStrategy interestStrategy)
        {
            _interestStrategy = interestStrategy;
        }

        public override decimal calculateBalance(int pTermInDays)
        {
           InterestResult result = _interestStrategy.calculateInterest(pTermInDays);

           _interestEarned = result.InterestEarned;
           _annualInterest = result.AnnualInterest;

           return result.FinalBalance;
            
        }
    }
}
