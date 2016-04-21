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
        private ICalculateInterestTermStrategy _strategy;
        private TermInterest _interestTable;

        public override decimal calculateBalance(decimal pAmount, int pTermInDays)
        {
            _interestTable.Term = pTermInDays;

            InterestResult result = _strategy.calculateInterest(_interestTable);

            return result.FinalBalance;
            
        }
    }
}
