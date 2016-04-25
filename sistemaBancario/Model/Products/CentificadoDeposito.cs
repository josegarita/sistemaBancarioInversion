using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    public class CentificadoDeposito : InvestementProduct
    {

        public CentificadoDeposito()
        {
            _interestPerformance = new InterestPerformanceByTerm();
            taxStrategy = new TaxStrategy.CertificadoRentaDeductionStrategy();
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
