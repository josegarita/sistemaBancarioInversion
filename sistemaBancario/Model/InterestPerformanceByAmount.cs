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
        private ICalculateInterestStrategy _interestStrategy;
        private AmountInterest _interest;

        public InterestPerformanceByAmount(AmountInterest pInterest, ICalculateInterestStrategy pInterestStrategy)
        {
            _interestStrategy = pInterestStrategy;
            _interest = pInterest;
        }

        public void setStrategy(ICalculateInterestStrategy pInterestStrategy)
        {
            _interestStrategy = pInterestStrategy;
        }

        public double geAnnualtInterest()
        {
            return _annualInterest;
        }

        public decimal getEarnedInterest()
        {
            return _interestEarned;
        }


        public override decimal calculateBalance(decimal pAmount, int pTermInDays)
        {
            _interest.Amount = pAmount;
           InterestResult result = _interestStrategy.calculateInterest(pTermInDays, _interest);

           _interestEarned = result.InterestEarned;
           _annualInterest = result.AnnualInterest;

           return result.FinalBalance;
            
        }
    }
}
