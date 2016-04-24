using Model.InterestCalculationStrategy;
using Model.InterestsUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class InterestPerformanceByTerm : AbstractInterestPerformance
    {
        private ICalculateInterestTermStrategy _interestStrategy = new CalculateInterestByTermStrategy();
        private TermInterest _interestTable;

        public override decimal calculateBalance(decimal pAmount, int pTermInDays)
        {
            _interestTable.Term = pTermInDays;
            _interestTable.Amount = pAmount;        

            InterestResult result = _interestStrategy.calculateInterest(_interestTable);

            _interestEarned = result.InterestEarned;
            _annualInterest = result.AnnualInterest;

            return result.FinalBalance;
        }

        public override void setInterestTable(InterestTable interest)
        {
            _interestTable = (TermInterest)interest;
        }

        public void setStrategy(ICalculateInterestTermStrategy pInterestStrategy)
        {
            _interestStrategy = pInterestStrategy;
        }

  
    }
}
