using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.InterestCalculationStrategy;

namespace Model.Products
{
    public class CuentaCorriente : Account
    {

        public CuentaCorriente ()
        {
            _interestPerformance = new InterestPerformanceByAmount();
            taxStrategy = new TaxStrategy.NullTaxStrategy();
        }

        public override void calculateInterest()
        {
            _interestPerformance.calculateBalance(this.amount, this.termInDays);
         
        }

        public override float getAnnualInterest()
        {
           return _interestPerformance.getAnnualInterest;
        }

        public override decimal getFinalBalance()
        {
            decimal tax = taxStrategy.calculateTaxDedution(_interestPerformance.getInterestEarned);

            decimal realInterestEarned = _interestPerformance.getInterestEarned - tax;

            return this.amount + realInterestEarned;
        }

        public override decimal InterestEarned()
        {
            return _interestPerformance.getInterestEarned;
        }

    }
}
