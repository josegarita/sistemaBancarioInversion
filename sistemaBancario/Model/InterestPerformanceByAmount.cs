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
        private ICalculateInterestAmountStrategy _interestStrategy = new CalculateInterestByAmountStrategy();
        private AmountInterest _interestTable;

        public InterestPerformanceByAmount()
        {

        }

        public InterestPerformanceByAmount(ICalculateInterestAmountStrategy pInterestStrategy)
        {
            _interestStrategy = pInterestStrategy;
         }

        public void setStrategy(ICalculateInterestAmountStrategy pInterestStrategy)
        {
            _interestStrategy = pInterestStrategy;
        }

        public override void setInterestTable (InterestTable interest)
        {
            _interestTable = (AmountInterest) interest;
        }


        public override decimal calculateBalance(decimal pAmount, int pTermInDays)
        {
            _interestTable.Amount = pAmount;
            InterestResult result = _interestStrategy.calculateInterest(pTermInDays, _interestTable);
            _interestEarned = result.InterestEarned;
            _annualInterest = result.AnnualInterest;
            return result.FinalBalance;
            
        }

    }
}
